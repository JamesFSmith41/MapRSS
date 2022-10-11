using BingMapsRESTToolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;
using System.Windows.Forms.Integration;
using System.Net;

namespace MapRSS
{
    public partial class MainInterface : Form
    {
        RSSFeed rss = new RSSFeed();
        TreeNode collection = new TreeNode("Collection");
        TreeNode topicNode = new TreeNode("Topics");
        LocationFinder locFinder;
        string topic;
        List<string> keywords = new List<string>();
        Topics topics = new Topics();
        MapRSS.UserControl1 mapControls = new MapRSS.UserControl1();
        bool feedViewerIsVisible = true;
        public MainInterface()
        {
            InitializeComponent();
            elementHost1.Hide();
            articleViewer.GridLines = true;
            articleViewer.Enabled = true;
            articleViewer.View = View.Details;
            mapFeed.Hide();
            mapFeed.Enabled = false;
            loadFeeds();

            articleViewer.Columns.Add("Title", 600);
            articleViewer.Columns.Add("Date", 150);

            collection = new TreeNode("Collection");
            feedViewer.Nodes.Add(collection);
            topicTreeView.Nodes.Add(topicNode);
            rss = new RSSFeed();
            elementHost1.Child = mapControls;
            this.Controls.Add(elementHost1);
            mapControls.PushPinClicked += PushPin_click; 
            locFinder = new LocationFinder();
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        // Loads intial feeds.
        private void loadFeeds()
        {
            RSSFeed feeds = new RSSFeed();
            Dictionary<string, Feed> articleFeeds = feeds.GetFeeds();
            foreach(Feed items in articleFeeds.Values)
            {
                TreeNode newNode = new TreeNode();

                feedViewer.SelectedNode.Nodes.Add(newNode);
            }
        }

        //Searches for rss feed.
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (urlSearchBar.Text != "")
            {
              
                SyndicationFeed feed = rss.SearchForFeed(urlSearchBar.Text, "");
                if (feed != null)
                {
                    TreeNode rssFeedNode = new TreeNode(feed.Title.Text);
                    if (feedViewer.SelectedNode != null)
                    {
                        feedViewer.SelectedNode.Nodes.Add(rssFeedNode);
                    }
                    else
                    {
                        collection.Nodes.Add(rssFeedNode);
                    }
                    FindMapLocations(feed.Title.Text);
                }



                
                urlSearchBar.Text = "";
            }
        }
        // Handles displaying article.
        private void articleViewer_MouseClick(object sender, MouseEventArgs e)
        {
            string articleName = articleViewer.SelectedItems[0].Text;
            SyndicationItem item = rss.GetArticle(articleName);
            webBrowser1.Navigate(item.Id);
            articleViewer.SelectedItems[0].ForeColor = Color.Gray;
        }

        
        private void feedViewer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List<SyndicationItem> articles = rss.GetAllArticles(e.Node.Text);

            if(articles != null)
            {
                articleViewer.Clear();
                articleViewer.Columns.Add("Title", 600);
                articleViewer.Columns.Add("Date", 150);

                foreach (SyndicationItem item in articles)
                {
                    string[] arr = new string[2];
                    arr[0] = item.Title.Text;
                    arr[1] = item.PublishDate.ToString();
                    ListViewItem article = new ListViewItem(arr);
                    article.ForeColor = Color.Black;
                    articleViewer.Items.Add(article);
                    
                }
            }
            
        }

        private void searchTopicsBtn_Click(object sender, EventArgs e)
        {
            if (keywordSearchTextBox.Text != "" && topicSearchTextBox.Text != "")
            {
                topic = topicSearchTextBox.Text;
                string[] keywords = keywordSearchTextBox.Text.Split(' ');
                TreeNode newTopic = new TreeNode(topic);
                if (topicTreeView.SelectedNode != null)
                {
                    topicTreeView.SelectedNode.Nodes.Add(newTopic);
                }
                else
                {
                    topicNode.Nodes.Add(newTopic);
                }
                List<SyndicationItem> feedItems = rss.KeywordSearch(keywords);
                topics.AddTopic(topic, keywords, feedItems);
                if (feedItems != null)
                {
                    articleViewer.Clear();
                    articleViewer.Columns.Add("Title", 600);
                    articleViewer.Columns.Add("Date", 150);

                    foreach (SyndicationItem item in feedItems)
                    {
                        string[] arr = new string[2];
                        arr[0] = item.Title.Text;
                        arr[1] = item.PublishDate.ToString();
                        ListViewItem article = new ListViewItem(arr);
                        articleViewer.Items.Add(article);
                    }
                }
            }
        }

        private void topicTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List<SyndicationItem> articles = topics.GetTopicArticles(e.Node.Text);

            if (articles != null)
            {
                articleViewer.Clear();
                articleViewer.Columns.Add("Title", 600);
                articleViewer.Columns.Add("Date", 150);

                foreach (SyndicationItem item in articles)
                {
                    string[] arr = new string[2];
                    arr[0] = item.Title.Text;
                    arr[1] = item.PublishDate.ToString();
                    ListViewItem article = new ListViewItem(arr);
                    article.ForeColor = Color.Black;
                    articleViewer.Items.Add(article);
                }
            }
        }

        private void topicsToolStrip_Click(object sender, EventArgs e)
        {
            FileManager file = new FileManager();
            Dictionary<string, string> filesContents = file.LoadFileTopic();
            topicTreeView.Nodes.Clear();
            feedViewer.Nodes.Clear();
            TreeNode collection = new TreeNode("TopicFeed");
            TreeNode top = new TreeNode(file.GetFileName());
            feedViewer.Nodes.Add(collection);
            topicTreeView.Nodes.Add(top);
            foreach (string title in filesContents.Keys)
            {
                SyndicationFeed feed = rss.SearchForFeed(filesContents[title], title);
                TreeNode rssFeedNode = new TreeNode(title);
                collection.Nodes.Add(rssFeedNode);
                FindMapLocations(feed.Title.Text);
            }

            Dictionary<string, string> topicList = file.GetKeywords();
            foreach(string key in topicList.Keys)
            {
                topic = key;
                string[] keywords = topicList[key].Split(' ');
                TreeNode newTopic = new TreeNode(topic);
                if (topicTreeView.SelectedNode != null)
                {
                    topicTreeView.SelectedNode.Nodes.Add(newTopic);
                }
                else
                {
                    topicTreeView.Nodes.Add(newTopic);
                }
                List<SyndicationItem> feedItems = rss.KeywordSearch(keywords);
                topics.AddTopic(topic, keywords, feedItems);
                
            }
        }
    

        private void feedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager file = new FileManager();
            Dictionary<string, string> filesContents = file.LoadFileFeed();
            feedViewer.Nodes.Clear();
            TreeNode collection = new TreeNode(file.GetFileName());
            feedViewer.Nodes.Add(collection);
            rss = new RSSFeed();
            foreach (string title in filesContents.Keys)
            {
                SyndicationFeed feed = rss.SearchForFeed(filesContents[title], title);
                TreeNode rssFeedNode = new TreeNode(title);
                collection.Nodes.Add(rssFeedNode);
                FindMapLocations(feed.Title.Text);
            }
        }

        private void feedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager file = new FileManager();
            file.SaveFeed(collection.Text, rss.GetUrls());
        }

        private void topicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager file = new FileManager();

            file.SaveTopics(topicNode.Text, topics.GetKeywords(), rss.GetUrls());
        }

        //Filter By time functions.
        private void filterByTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterByTimeBtn.Show();
            cancelFilterTimeBtn.Show();
            timeFilterPanel.Show();
            timeFilterText.Show();
            fromTxtBox.Show();
            toTextBox.Show();
            filterFromTxt.Show();
            filterFromTxt.Text = "";
            filterToTimeTxt.Text = "";
            filterToTimeTxt.Show();

        }

        private void cancelFilterTimeBtn_Click(object sender, EventArgs e)
        {
            filterByTimeBtn.Hide();
            cancelFilterTimeBtn.Hide();
            timeFilterPanel.Hide();
            timeFilterText.Hide();
            fromTxtBox.Hide();
            toTextBox.Hide();
            filterFromTxt.Hide();
            filterToTimeTxt.Hide();
        }

        private void filterByTimeBtn_Click(object sender, EventArgs e)
        {
            List<ListViewItem> listItems = new List<ListViewItem>();
            try
            {
                DateTime fromTime = DateTime.Parse(filterFromTxt.Text);
                DateTime toTime = DateTime.Parse(filterToTimeTxt.Text);
                foreach (ListViewItem item in articleViewer.Items)
                {
                    DateTime time = DateTime.Parse(item.SubItems[1].Text);
                    if (DateTime.Compare(time, fromTime) >= 0 && DateTime.Compare(time, toTime) <= 0)
                    {
                        listItems.Add(item);
                    }
                }
                articleViewer.Clear();
                articleViewer.Columns.Add("Title", 600);
                articleViewer.Columns.Add("Date", 150);

                foreach (ListViewItem item in listItems)
                {
                    articleViewer.Items.Add(item);
                }
            }
            catch(FormatException x)
            {

            }
           
            filterByTimeBtn.Hide();
            cancelFilterTimeBtn.Hide();
            timeFilterPanel.Hide();
            timeFilterText.Hide();
            fromTxtBox.Hide();
            toTextBox.Hide();
            filterFromTxt.Hide();
            filterToTimeTxt.Hide();
        }


        // Deletes collection
        private void cutFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (feedViewer.SelectedNode.Parent != null && feedViewer.SelectedNode.Nodes.Count == 0)
                {
                    rss.RemoveFeed(feedViewer.SelectedNode.Text);
                    feedViewer.SelectedNode.Remove();
                }
            }
            catch(NullReferenceException x)
            {

            }
        }

        private async Task FindMapLocations(string feedName)
        {
            Dictionary<string, string[]> locations = rss.ParseForLocations(feedName);
            foreach(KeyValuePair<string, string[]> location in locations)
            {
                await GetLocationAsync(location);
            }
        }
        private async Task GetLocationAsync(KeyValuePair<string, string[]> location)
        {
            await locFinder.FindLocationAsync(location.Value[1]);

            Coordinate coord = locFinder.GetCoordinate(location.Value[1]);
            if (coord != null)
            {
                mapControls.AddPin(coord, location);
            }
        }

        private void PushPin_click(object sender, EventArgs e)
        {
            string pinTitle = mapControls.GetPinText();
            string pinDesc = mapControls.GetPinDesc();
            closeMapArticleBtn.Enabled = true;
            viewMapArticleBtn.Enabled = true;
            closeMapArticleBtn.Show();
            viewMapArticleBtn.Show();
            mapArticleDesc.Enabled = true;
            mapArticleTitle.Enabled = true;
            mapArticleDesc.Show();
            mapArticleTitle.Show();
            mapArticleDesc.Text = "Article Description: " + pinDesc;
            mapArticleTitle.Text = "Title: " + pinTitle;
            mapArticlePanel.Show();
            mapArticlePanel.Enabled = true;
        }
        // Changes the name of a collection.
        private void changeNameBtn_Click(object sender, EventArgs e)
        {

            if (collectionNamerTxtBox.Text == "")
            {
                TreeNode newNode = new TreeNode("Collection");
                if (feedViewerIsVisible == true)
                {
                    if (feedViewer.SelectedNode != null)
                    {
                        feedViewer.SelectedNode.Nodes.Add(newNode);
                    }
                    else
                    {
                        feedViewer.Nodes.Add(newNode);
                    }
                }
                else
                {
                    if (topicTreeView.SelectedNode != null)
                    {
                        topicTreeView.SelectedNode.Nodes.Add(newNode);
                    }
                    else
                    {
                        topicTreeView.Nodes.Add(newNode);
                    }
                }
                
            }
            else
            {
                TreeNode node = new TreeNode(collectionNamerTxtBox.Text);
                if(feedViewerIsVisible == true)
                {
                    if (feedViewer.SelectedNode == null)
                    {
                        feedViewer.Nodes.Add(node);
                    }
                    else
                    {
                        feedViewer.SelectedNode.Nodes.Add(node);

                    }
                }
                else
                {
                    if (topicTreeView.SelectedNode == null)
                    {
                        topicTreeView.Nodes.Add(node);
                    }
                    else
                    {
                        topicTreeView.SelectedNode.Nodes.Add(node);

                    }
                }
                
                collectionNamerTxtBox.Text = "";
            }

            newCollectionNameBtn.Enabled = false;
            newCollectionNameBtn.Hide();
            collectionNamerTxtBox.Enabled = false;
            collectionNamerTxtBox.Hide();
            CollectionNameTxtBox.Enabled = false;
            CollectionNameTxtBox.Hide();
            newCollectionPanel.Enabled = false;
            newCollectionPanel.Hide();
        }

        private void feedViewBtn_Click(object sender, EventArgs e)
        {
            searchTopicsBtn.Enabled = false;
            searchTopicsBtn.Hide();
            topicSearchTextBox.Hide();
            topicSearchTextBox.Enabled = false;
            topicTextBox.Hide();
            topicTextBox.Enabled = false;
            keywordSearchTextBox.Hide();
            keywordSearchTextBox.Enabled = false;
            keywordTextBox.Hide();
            keywordTextBox.Enabled = false;
            filterBtn.Enabled = true;
            filterBtn.Show();
            feedViewer.Show();
            feedViewer.Enabled = true;
            topicTreeView.Hide();
            topicTreeView.Enabled = false;
            feedViewBtn.Hide();
            feedViewBtn.Enabled = false;
            feedViewerIsVisible = true;

        }
        private void filterBtn_Click(object sender, EventArgs e)
        {
            searchTopicsBtn.Enabled = true;
            searchTopicsBtn.Show();
            topicSearchTextBox.Show();
            topicSearchTextBox.Enabled = true;
            topicTextBox.Show();
            topicTextBox.Enabled = true;
            keywordSearchTextBox.Show();
            keywordSearchTextBox.Enabled = true;
            keywordTextBox.Show();
            keywordTextBox.Enabled = true;
            filterBtn.Enabled = false;
            filterBtn.Hide();
            feedViewer.Hide();
            feedViewer.Enabled = false;
            topicTreeView.Show();
            topicTreeView.Enabled = true;
            feedViewBtn.Show();
            feedViewBtn.Enabled = true;
            topicTreeView.Show();
            feedViewer.Hide();
            feedViewerIsVisible = false;

        }

        // Rename collection names.
        private void cancelRenameBtn_Click(object sender, EventArgs e)
        {
            confirmRenameBtn.Hide();
            cancelRenameBtn.Hide();
            renameCollectionEntry.Hide();
            renameTextbox.Hide();
            renamePanel.Hide();
            confirmRenameBtn.Enabled = false;
            cancelRenameBtn.Enabled = false;
            renameCollectionEntry.Enabled = false;
            renameTextbox.Enabled = false;

            renameCollectionEntry.Text = "";
        }

        private void renameCollectionFileBtn_Click(object sender, EventArgs e)
        {
            confirmRenameBtn.Show();
            cancelRenameBtn.Show();
            renameCollectionEntry.Show();
            renameTextbox.Show();
            renamePanel.Show();
            renamePanel.Enabled = true;
            confirmRenameBtn.Enabled = true;
            cancelRenameBtn.Enabled = true;
            renameCollectionEntry.Enabled = true;
            renameTextbox.Enabled = true;

        }

        private void confirmRenameBtn_Click(object sender, EventArgs e)
        {
            if (renameCollectionEntry.Text != "")
            {
                if(feedViewerIsVisible == true)
                {
                    if (feedViewer.SelectedNode != null)
                    {
                        rss.RenameFeed(feedViewer.SelectedNode.Text, renameCollectionEntry.Text);
                        feedViewer.SelectedNode.Text = renameCollectionEntry.Text;
                    } 
                }
                else
                {
                    if (topicTreeView.SelectedNode != null)
                    {
                        topicTreeView.SelectedNode.Text = renameCollectionEntry.Text;
                    }
                }
               
                confirmRenameBtn.Hide();
                cancelRenameBtn.Hide();
                renameCollectionEntry.Hide();
                renameTextbox.Hide();
                renamePanel.Hide();

                confirmRenameBtn.Enabled = false;
                cancelRenameBtn.Enabled = false;
                renameCollectionEntry.Enabled = false;
                renameTextbox.Enabled = false;
                renamePanel.Enabled = false;
                renameCollectionEntry.Text = "";
            }
        }

        // New collection functions.
        private void newFileBtn_Click(object sender, EventArgs e)
        {
            newCollectionPanel.Show();
            newCollectionPanel.Enabled = true;
            cancelColBtn.Enabled = true;
            cancelColBtn.Show();
            newCollectionNameBtn.Enabled = true;
            newCollectionNameBtn.Show();
            collectionNamerTxtBox.Show();
            collectionNamerTxtBox.Enabled = true;
            CollectionNameTxtBox.Show();
            CollectionNameTxtBox.Enabled = true;
        }


        private void closeMapBtn_Click(object sender, EventArgs e)
        {
            closeMapBtn.Hide();
            closeMapBtn.Enabled = false;
            elementHost1.Hide();
            elementHost1.Enabled = false;
            articleViewer.Show();
            articleViewer.Enabled = true;
            mapFeed.Hide();
            mapFeed.Enabled = false;
            webBrowser1.Show();
        }
        private void confirmColBtn_Click(object sender, EventArgs e)
        {
            cancelColBtn.Enabled = false;
            cancelColBtn.Hide();
            newCollectionNameBtn.Enabled = true;
            newCollectionNameBtn.Show();
            collectionNamerTxtBox.Enabled = true;
            collectionNamerTxtBox.Show();
            CollectionNameTxtBox.Enabled = true;
            CollectionNameTxtBox.Show();
        }

        private void cancelColBtn_Click(object sender, EventArgs e)
        {
            cancelColBtn.Enabled = false;
            cancelColBtn.Hide();
            newCollectionPanel.Hide();
            newCollectionPanel.Enabled = false;


        }

        private void viewMapArticleBtn_Click(object sender, EventArgs e)
        {
            closeMapArticleBtn.Enabled = false;
            viewMapArticleBtn.Enabled = false;
            closeMapArticleBtn.Hide();
            viewMapArticleBtn.Hide();
            mapArticleDesc.Enabled = false;
            mapArticleTitle.Enabled = false;
            mapArticleDesc.Hide();
            mapArticleTitle.Hide();
            mapArticlePanel.Hide();
            mapArticlePanel.Enabled = false;
            articleViewer.Clear();
            string title = mapArticleTitle.Text.Remove(0, 7);
            List<SyndicationItem> articles = rss.GetAllArticles(rss.GetFeedName(title));

            if (articles != null)
            {
                articleViewer.Clear();
                articleViewer.Columns.Add("Title", 600);
                articleViewer.Columns.Add("Date", 150);

                foreach (SyndicationItem item in articles)
                {
                    string[] arr = new string[2];
                    arr[0] = item.Title.Text;
                    arr[1] = item.PublishDate.ToString();
                    
                    ListViewItem article = new ListViewItem(arr);
                    if (arr[0] == title)
                    {
                        article.ForeColor = Color.Gray;
                    }
                    else
                    {
                        article.ForeColor = Color.Black;
                    }    
                    articleViewer.Items.Add(article);

                }
            }
            SyndicationItem newsItem = rss.GetArticle(title);
            webBrowser1.Navigate(newsItem.Id);
            closeMapBtn.Hide();
            closeMapBtn.Enabled = false;
            elementHost1.Hide();
            elementHost1.Enabled = false;
            articleViewer.Show();
            articleViewer.Enabled = true;
            mapFeed.Hide();
            mapFeed.Enabled = false;
            webBrowser1.Show();
        }

        private void closeMapArticleBtn_Click(object sender, EventArgs e)
        {
            closeMapArticleBtn.Enabled = false;
            viewMapArticleBtn.Enabled = false;
            closeMapArticleBtn.Hide();
            viewMapArticleBtn.Hide();
            mapArticleDesc.Enabled = false;
            mapArticleTitle.Enabled = false;
            mapArticleDesc.Hide();
            mapArticleTitle.Hide();
        }

        private void openMapToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            elementHost1.Show();
            elementHost1.Enabled = true;
            articleViewer.Hide();
            articleViewer.Enabled = false;
            closeMapBtn.Show();
            closeMapBtn.Enabled = true;
            mapFeed.Show();
            mapFeed.Enabled = true;
            webBrowser1.Hide();
        }


    }
}
