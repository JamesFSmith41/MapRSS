using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace MapRSS
{

    public class RSSFeed
    {
        Dictionary<string , Feed> feeds = new Dictionary<string , Feed>();
        List<SyndicationItem> articles = new List<SyndicationItem>();

        public RSSFeed(){}

        public RSSFeed(Dictionary<string, Feed> feeds)
        {
            this.feeds = feeds; 
        }

        public Dictionary<string, Feed> GetFeeds()
        {
            return feeds;
        }

        public Dictionary<string, string> GetUrls()
        {
            Dictionary<string, string> urls = new Dictionary<string, string>();
            foreach (string s in feeds.Keys)
            {
                urls.Add(s, feeds[s].GetUrl());
            }
            return urls;
        }

        public List<string> GetAllUrls()
        {
            List<string> urls = new List<string>();
            foreach(string key in feeds.Keys)
            {
                urls.Add(feeds[key].GetUrl());
            }
            return urls;
        }

        public void RenameFeed(string orgName, string name)
        {
            if (feeds.ContainsKey(orgName))
            {
                Feed feed = feeds[orgName];
                feeds.Remove(orgName);
                feeds.Add(name, feed);
            }
            
        }
        public List<SyndicationItem> GetAllArticles(string title)
        {
            if (feeds.ContainsKey(title))
            {
                return feeds[title].GetAllArticles();

            }
            else
            {
                return null;
            }
        }

        public SyndicationFeed SearchForFeed(string url, string title)
        {
            XmlReader reader;
            SyndicationFeed feed;
            Feed feedItem = null;
            try
            {
                reader = XmlReader.Create(url);
            }
            catch (System.ArgumentException e)
            {
                return null;
            }
            catch(System.IO.FileNotFoundException e)
            {
                return null;
            }
            try
            {
                feed = SyndicationFeed.Load(reader);
                reader.Close();
                if (feeds.ContainsKey(feed.Title.Text))
                {
                    return null;
                }
                if (title == "")
                {
                    if (feeds.ContainsKey(feed.Title.Text) != true)
                    {
                        feedItem = new Feed(feed, url);
                        feeds.Add(feed.Title.Text, feedItem);
                    }
                }
                else
                {
                    feedItem = new Feed(feed, url, title);
                    feeds.Add(title, feedItem);
                }
                
               
                List<SyndicationItem> articleList = feedItem.GetAllArticles();
                return feed;
            }
            catch (XmlException e)
            {
                reader.Close();
                return null; 

            }
        }

        public SyndicationItem GetArticle(string title)
        {
            foreach (Feed feedItems in feeds.Values)
            {
                SyndicationItem feed = feedItems.FindArticle(title);
                if (feed != null)
                {
                    return feedItems.FindArticle(title);
                }
            }
            return null;
        }

        public List<SyndicationItem> KeywordSearch(string[] keywords)
        {
            List<SyndicationItem> matches = new List<SyndicationItem>();
            AddArticles();
            foreach (string keyword in keywords)
            {
                foreach(SyndicationItem item in articles)
                {
                    if (item.Title.Text.Contains(keyword))
                    {
                        matches.Add(item);
                    }
                    else if (item.Summary.Text.Contains(keyword))
                    {
                        matches.Add(item);
                    }
                }
            }
            return matches;
        }

        public void RemoveFeed(string title)
        {
            if (feeds.ContainsKey(title))
            {
                feeds.Remove(title);
            }
        }

        public string GetFeedName(string article)
        {
            foreach (string feedName in feeds.Keys)
            {
                if (feeds[feedName].HasArticle(article))
                {
                    return feedName;
                }
            }
            return null;
        }

        private void AddArticles()
        {
            articles = new List<SyndicationItem>();
            foreach(string key in feeds.Keys)
            {
                foreach (SyndicationItem item in feeds[key].GetAllArticles())
                {
                    articles.Add(item);
                }       
            }
        }
        public Dictionary<string, string[]> ParseForLocations(string name)
        {
            var curDir = Directory.GetCurrentDirectory();
            string usLocationsPath = curDir.ToString();
            int index = usLocationsPath.Length;
            usLocationsPath = usLocationsPath.Remove(index - 9, 9) + "\\Locations\\uslocations.csv";


            Feed feed = feeds[name];
            Dictionary<string, string[]> locations = new Dictionary<string, string[]>();
            foreach(SyndicationItem item in feed.GetAllArticles())
            {
                bool foundLoc = false;
                string[] words = item.Title.Text.Split(' ');
                    using (TextFieldParser parser = new TextFieldParser(usLocationsPath))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");
                        while (!parser.EndOfData && foundLoc == false)
                        {

                            string[] fields = parser.ReadFields();
                            foreach (string field in fields)
                            {
                                foreach( string s in words)
                                {
                                if (field == s && field != "" && field != "Man" && field != "Deputy")
                                    {
                                    locations.Add(item.Title.Text, new string[2]);
                                    locations[item.Title.Text][0] = item.Summary.Text;
                                    locations[item.Title.Text][1] = field;
                                    foundLoc = true;
                                    break;
                                    }
                                }
                               
                            }
                        }
                    }
                
            }
            return locations;
        }
    }
}
