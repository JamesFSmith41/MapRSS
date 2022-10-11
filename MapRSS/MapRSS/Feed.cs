using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.IO;

namespace MapRSS
{
    public class Feed
    {
        List<SyndicationItem> items = new List<SyndicationItem>();
        string feedName;
        string url;

        public Feed(SyndicationFeed feed, string url) 
        {
            this.feedName = feed.Title.Text;
            this.url = url;
            int synItems = feed.Items.Count();

            for (int i = 0; i < synItems; i++)
            {
                items.Add(feed.Items.ElementAt(i));
            }
        }

        public Feed(SyndicationFeed feed, string url, string name)
        {
            this.feedName = name;
            this.url = url;
            int synItems = feed.Items.Count();

            for (int i = 0; i < synItems; i++)
            {
                items.Add(feed.Items.ElementAt(i));
            }
        }
        public SyndicationItem GetItem(int index)
        {
            return items.ElementAt(index);
        }

        public List<SyndicationItem> GetAllArticles()
        {
            return items;
        }

        public string GetUrl()
        {
            return url;
        }
        public SyndicationItem FindArticle(string title)
        {
            foreach (SyndicationItem item in items)
            {
                if (item.Title.Text == title)
                {
                    return item;
                }
            }
            return null;
        }

        public bool HasArticle(string article)
        {
            foreach (SyndicationItem item in items)
            {
                if (item.Title.Text == article)
                {
                    return true;
                }
            }
            return false;
        }
        
        public string GetFeedName()
        {
            return this.feedName;
        }
    }
}