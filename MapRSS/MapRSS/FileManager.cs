using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace MapRSS
{
    public class FileManager
    {
        string fileName;
        string treeName;
        Dictionary<string, string> keywords;
        public FileManager() { }

        public string GetFileName()
        {
            return fileName;
        }
        public void SaveFeed(string title, Dictionary<string, string> urls)
        {
            xmlCreatorFeeds(title, urls);
        }

        public void SaveTopics(string title, Dictionary<string, string[]> keywords, Dictionary<string, string> feeds)
        {
            xmlCreatorTopics(title, keywords, feeds);
        }

        public Dictionary<string, string> LoadFileFeed()
        {
            Dictionary<string, string> contents = new Dictionary<string, string>();

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "XML-File | *.xml";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                XmlTextReader reader = new XmlTextReader(openFile.OpenFile());
                string url = "";
                string title = "";
                int counter = 0;
                fileName = openFile.SafeFileName;
                fileName = fileName.Remove(fileName.Length - 4, 4);
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Text:
                            if (counter == 0)
                            {
                                title = reader.Value;
                                counter++;
                            }
                            else if (counter == 1)
                            {
                                url = reader.Value;
                                counter++;
                            }
                            break;
                    }
                    if (counter == 2)
                    {
                        counter = 0;
                        contents.Add(title, url);
                    }
                }
            }
            return contents;
        }

        public Dictionary<string, string> LoadFileTopic()
        {
            Dictionary<string, string> contents = new Dictionary<string, string>();
            keywords = new Dictionary<string, string>();

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "XML-File | *.xml";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                XmlTextReader reader = new XmlTextReader(openFile.OpenFile());
                string title = "";
                string topicName = "";
                treeName = "";
                fileName = openFile.SafeFileName;
                fileName = fileName.Remove(fileName.Length - 4, 4);
                while (reader.Read())
                {
                    if (reader.Name == "topicName")
                    {
                        reader.Read();
                        topicName = reader.Value;
                        reader.Read();

                    }
                    else if (reader.Name == "keyword")
                    {
                        reader.Read();
                        string keyword = reader.Value;
                        keywords.Add(topicName, keyword);
                        reader.Read();
                    }
                    else if (reader.Name == "feedName")
                    {
                        reader.Read();
                        title = reader.Value;
                        reader.Read();
                    }
                    else if (reader.Name == "feedUrl")
                    {
                        reader.Read();
                        string url = reader.Value;
                        contents.Add(title, url);
                        reader.Read();
                    }
                    else if (reader.Name == "TopicTreeName")
                    {
                        reader.Read();
                        treeName = reader.Value;
                        reader.Read();
                    }
                    
                }
            }
            return contents;
        }

        private void xmlCreatorTopics(string title, Dictionary<string, string[]> keywords, Dictionary<string, string> urls)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            var curDir = Directory.GetCurrentDirectory();
            string fileName = curDir.ToString();
            int index = fileName.Length;
            fileName = fileName.Remove(index - 9, 9);
            fileName += "\\Feeds\\";
            fileName += title + ".xml";
            XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("topics");

            xmlWriter.WriteStartElement("TopicTreeName");
            xmlWriter.WriteString(title);
            xmlWriter.WriteEndElement();
            foreach (string topic in keywords.Keys)
            {
                xmlWriter.WriteStartElement("topicName");
                xmlWriter.WriteString(topic);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("keyword");
                foreach (string keyword in keywords[topic])
                {
                    xmlWriter.WriteString(keyword + " ");
                }
                xmlWriter.WriteEndElement();
               
            }
           
            xmlWriter.WriteStartElement("Feeds");
            foreach (string pair in urls.Keys)
            {
                xmlWriter.WriteStartElement("feedName");
                xmlWriter.WriteString(pair);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("feedUrl");
                xmlWriter.WriteString(urls[pair]);
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        private void xmlCreatorFeeds (string title, Dictionary<string, string> urls)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            var curDir = Directory.GetCurrentDirectory();
            string fileName = curDir.ToString();
            int index = fileName.Length;
            fileName = fileName.Remove(index - 9, 9);
            fileName += "\\Feeds\\";
            fileName += title + ".xml";
            XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("feed");

            foreach (string pair in urls.Keys)
            {
                xmlWriter.WriteStartElement("feedName");
                xmlWriter.WriteString(pair);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("feedUrl");
                xmlWriter.WriteString(urls[pair]);
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        public Dictionary<string, string> GetKeywords()
        {
            return keywords;
        }
    }
}
