using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace MapRSS
{
    public class Topics
    {
        Dictionary<string, List<SyndicationItem>> topics = new Dictionary<string, List<SyndicationItem>>();
        Dictionary<string, string[]> keywords = new Dictionary<string, string[]>();

        public Topics() { }

        public void AddTopic(string topicName, string[] keyword, List<SyndicationItem> articles)
        {
            if (articles.Count != 0)
            {
                if (topics.ContainsKey(topicName))
                {
                    topics[topicName] = articles;
                    keywords[topicName] = keyword;
                }
                else
                {
                    topics.Add(topicName, articles);
                    keywords.Add(topicName, keyword);
                }
            }
        }

        public string[] GetKeywords(string topicName)
        {
            if (keywords.ContainsKey(topicName))
            {
                return keywords[topicName];
            }
            else
            {
                return null;
            }
        }
        public List<SyndicationItem> GetTopicArticles(string topicName)
        {
            if (topics.ContainsKey(topicName))
            {
                return topics[topicName];

            }
            return null;
        }

        public Dictionary<string, List<SyndicationItem>> GetTopics()
        {
            return topics;
        }

        public Dictionary<string, string[]> GetKeywords()
        {
            return keywords;
        }

    }
}
