
namespace MapRSS
{
    partial class MainInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.articleViewer = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.feedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMapBtn = new System.Windows.Forms.Button();
            this.feedViewer = new System.Windows.Forms.TreeView();
            this.newCollectionBtn = new System.Windows.Forms.Button();
            this.renameCollectionBtn = new System.Windows.Forms.Button();
            this.cutFileBtn = new System.Windows.Forms.Button();
            this.mapFeed = new System.Windows.Forms.RichTextBox();
            this.urlSearchBar = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.cancelColBtn = new System.Windows.Forms.Button();
            this.collectionNamerTxtBox = new System.Windows.Forms.RichTextBox();
            this.CollectionNameTxtBox = new System.Windows.Forms.RichTextBox();
            this.newCollectionNameBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.topicSearchTextBox = new System.Windows.Forms.RichTextBox();
            this.topicTextBox = new System.Windows.Forms.RichTextBox();
            this.keywordTextBox = new System.Windows.Forms.RichTextBox();
            this.keywordSearchTextBox = new System.Windows.Forms.RichTextBox();
            this.searchTopicsBtn = new System.Windows.Forms.Button();
            this.topicTreeView = new System.Windows.Forms.TreeView();
            this.feedViewBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.renameTextbox = new System.Windows.Forms.RichTextBox();
            this.renameCollectionEntry = new System.Windows.Forms.RichTextBox();
            this.confirmRenameBtn = new System.Windows.Forms.Button();
            this.cancelRenameBtn = new System.Windows.Forms.Button();
            this.mapArticleTitle = new System.Windows.Forms.RichTextBox();
            this.mapArticleDesc = new System.Windows.Forms.RichTextBox();
            this.viewMapArticleBtn = new System.Windows.Forms.Button();
            this.closeMapArticleBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mapArticlePanel = new System.Windows.Forms.Panel();
            this.renamePanel = new System.Windows.Forms.Panel();
            this.newCollectionPanel = new System.Windows.Forms.Panel();
            this.timeFilterPanel = new System.Windows.Forms.Panel();
            this.filterToTimeTxt = new System.Windows.Forms.RichTextBox();
            this.filterFromTxt = new System.Windows.Forms.RichTextBox();
            this.cancelFilterTimeBtn = new System.Windows.Forms.Button();
            this.filterByTimeBtn = new System.Windows.Forms.Button();
            this.toTextBox = new System.Windows.Forms.RichTextBox();
            this.fromTxtBox = new System.Windows.Forms.RichTextBox();
            this.timeFilterText = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new MapRSS.UserControl1();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mapArticlePanel.SuspendLayout();
            this.renamePanel.SuspendLayout();
            this.newCollectionPanel.SuspendLayout();
            this.timeFilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // articleViewer
            // 
            this.articleViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.articleViewer.HideSelection = false;
            this.articleViewer.Location = new System.Drawing.Point(240, 58);
            this.articleViewer.Name = "articleViewer";
            this.articleViewer.Size = new System.Drawing.Size(749, 216);
            this.articleViewer.TabIndex = 2;
            this.articleViewer.UseCompatibleStateImageBehavior = false;
            this.articleViewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.articleViewer_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.openMapToolStripMenuItem,
            this.filterByTimeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1006, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(123, 546);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.feedToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Topics";
            this.toolStripTextBox1.Click += new System.EventHandler(this.topicsToolStrip_Click);
            // 
            // feedToolStripMenuItem
            // 
            this.feedToolStripMenuItem.Name = "feedToolStripMenuItem";
            this.feedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.feedToolStripMenuItem.Text = "Feeds";
            this.feedToolStripMenuItem.Click += new System.EventHandler(this.feedToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feedsToolStripMenuItem,
            this.topicsToolStripMenuItem});
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // feedsToolStripMenuItem
            // 
            this.feedsToolStripMenuItem.Name = "feedsToolStripMenuItem";
            this.feedsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.feedsToolStripMenuItem.Text = "Feeds";
            this.feedsToolStripMenuItem.Click += new System.EventHandler(this.feedsToolStripMenuItem_Click);
            // 
            // topicsToolStripMenuItem
            // 
            this.topicsToolStripMenuItem.Name = "topicsToolStripMenuItem";
            this.topicsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.topicsToolStripMenuItem.Text = "Topics";
            this.topicsToolStripMenuItem.Click += new System.EventHandler(this.topicsToolStripMenuItem_Click);
            // 
            // openMapToolStripMenuItem
            // 
            this.openMapToolStripMenuItem.Name = "openMapToolStripMenuItem";
            this.openMapToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.openMapToolStripMenuItem.Text = "Map";
            this.openMapToolStripMenuItem.Click += new System.EventHandler(this.openMapToolStripMenuItem_Click_1);
            // 
            // filterByTimeToolStripMenuItem
            // 
            this.filterByTimeToolStripMenuItem.Name = "filterByTimeToolStripMenuItem";
            this.filterByTimeToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.filterByTimeToolStripMenuItem.Text = "Filter by Time";
            this.filterByTimeToolStripMenuItem.Click += new System.EventHandler(this.filterByTimeToolStripMenuItem_Click);
            // 
            // closeMapBtn
            // 
            this.closeMapBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeMapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.closeMapBtn.FlatAppearance.BorderSize = 0;
            this.closeMapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeMapBtn.Location = new System.Drawing.Point(1033, 0);
            this.closeMapBtn.Name = "closeMapBtn";
            this.closeMapBtn.Size = new System.Drawing.Size(97, 26);
            this.closeMapBtn.TabIndex = 4;
            this.closeMapBtn.Text = "Close Map";
            this.closeMapBtn.UseVisualStyleBackColor = false;
            this.closeMapBtn.Visible = false;
            this.closeMapBtn.Click += new System.EventHandler(this.closeMapBtn_Click);
            // 
            // feedViewer
            // 
            this.feedViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedViewer.Location = new System.Drawing.Point(15, 58);
            this.feedViewer.Name = "feedViewer";
            this.feedViewer.Size = new System.Drawing.Size(222, 534);
            this.feedViewer.TabIndex = 5;
            this.feedViewer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.feedViewer_AfterSelect);
            // 
            // newCollectionBtn
            // 
            this.newCollectionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.newCollectionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newCollectionBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newCollectionBtn.FlatAppearance.BorderSize = 0;
            this.newCollectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCollectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("newCollectionBtn.Image")));
            this.newCollectionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newCollectionBtn.Location = new System.Drawing.Point(0, 0);
            this.newCollectionBtn.Name = "newCollectionBtn";
            this.newCollectionBtn.Size = new System.Drawing.Size(156, 49);
            this.newCollectionBtn.TabIndex = 6;
            this.newCollectionBtn.Text = "New Collection";
            this.newCollectionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.newCollectionBtn, "New Feed Collection\r\n");
            this.newCollectionBtn.UseVisualStyleBackColor = false;
            this.newCollectionBtn.Click += new System.EventHandler(this.newFileBtn_Click);
            // 
            // renameCollectionBtn
            // 
            this.renameCollectionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.renameCollectionBtn.FlatAppearance.BorderSize = 0;
            this.renameCollectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renameCollectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("renameCollectionBtn.Image")));
            this.renameCollectionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.renameCollectionBtn.Location = new System.Drawing.Point(150, 0);
            this.renameCollectionBtn.Name = "renameCollectionBtn";
            this.renameCollectionBtn.Size = new System.Drawing.Size(158, 49);
            this.renameCollectionBtn.TabIndex = 7;
            this.renameCollectionBtn.Text = "Rename Feed";
            this.renameCollectionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.renameCollectionBtn, "Rename Collection\r\n");
            this.renameCollectionBtn.UseVisualStyleBackColor = false;
            this.renameCollectionBtn.Click += new System.EventHandler(this.renameCollectionFileBtn_Click);
            // 
            // cutFileBtn
            // 
            this.cutFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cutFileBtn.FlatAppearance.BorderSize = 0;
            this.cutFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cutFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("cutFileBtn.Image")));
            this.cutFileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutFileBtn.Location = new System.Drawing.Point(300, 0);
            this.cutFileBtn.Name = "cutFileBtn";
            this.cutFileBtn.Size = new System.Drawing.Size(161, 49);
            this.cutFileBtn.TabIndex = 8;
            this.cutFileBtn.Text = "Delete Collection";
            this.cutFileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.cutFileBtn, "Delete Collection");
            this.cutFileBtn.UseVisualStyleBackColor = false;
            this.cutFileBtn.Click += new System.EventHandler(this.cutFileBtn_Click);
            // 
            // mapFeed
            // 
            this.mapFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mapFeed.Location = new System.Drawing.Point(240, 509);
            this.mapFeed.Name = "mapFeed";
            this.mapFeed.ReadOnly = true;
            this.mapFeed.Size = new System.Drawing.Size(749, 85);
            this.mapFeed.TabIndex = 11;
            this.mapFeed.Text = "";
            // 
            // urlSearchBar
            // 
            this.urlSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlSearchBar.Location = new System.Drawing.Point(506, 3);
            this.urlSearchBar.Name = "urlSearchBar";
            this.urlSearchBar.Size = new System.Drawing.Size(222, 20);
            this.urlSearchBar.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(467, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(33, 26);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "url:";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(734, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(143, 19);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search for RSS";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cancelColBtn
            // 
            this.cancelColBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cancelColBtn.Enabled = false;
            this.cancelColBtn.FlatAppearance.BorderSize = 0;
            this.cancelColBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelColBtn.Location = new System.Drawing.Point(155, 36);
            this.cancelColBtn.Name = "cancelColBtn";
            this.cancelColBtn.Size = new System.Drawing.Size(177, 23);
            this.cancelColBtn.TabIndex = 18;
            this.cancelColBtn.Text = "Cancel";
            this.cancelColBtn.UseVisualStyleBackColor = false;
            this.cancelColBtn.Visible = false;
            this.cancelColBtn.Click += new System.EventHandler(this.cancelColBtn_Click);
            // 
            // collectionNamerTxtBox
            // 
            this.collectionNamerTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.collectionNamerTxtBox.Enabled = false;
            this.collectionNamerTxtBox.Location = new System.Drawing.Point(155, 3);
            this.collectionNamerTxtBox.Name = "collectionNamerTxtBox";
            this.collectionNamerTxtBox.Size = new System.Drawing.Size(177, 27);
            this.collectionNamerTxtBox.TabIndex = 20;
            this.collectionNamerTxtBox.Text = "";
            this.collectionNamerTxtBox.Visible = false;
            // 
            // CollectionNameTxtBox
            // 
            this.CollectionNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CollectionNameTxtBox.Enabled = false;
            this.CollectionNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionNameTxtBox.Location = new System.Drawing.Point(5, 3);
            this.CollectionNameTxtBox.Name = "CollectionNameTxtBox";
            this.CollectionNameTxtBox.ReadOnly = true;
            this.CollectionNameTxtBox.Size = new System.Drawing.Size(144, 27);
            this.CollectionNameTxtBox.TabIndex = 21;
            this.CollectionNameTxtBox.Text = "Enter Collection Name: ";
            this.CollectionNameTxtBox.Visible = false;
            // 
            // newCollectionNameBtn
            // 
            this.newCollectionNameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.newCollectionNameBtn.Enabled = false;
            this.newCollectionNameBtn.FlatAppearance.BorderSize = 0;
            this.newCollectionNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCollectionNameBtn.Location = new System.Drawing.Point(5, 36);
            this.newCollectionNameBtn.Name = "newCollectionNameBtn";
            this.newCollectionNameBtn.Size = new System.Drawing.Size(144, 23);
            this.newCollectionNameBtn.TabIndex = 22;
            this.newCollectionNameBtn.Text = "Enter";
            this.newCollectionNameBtn.UseVisualStyleBackColor = false;
            this.newCollectionNameBtn.Visible = false;
            this.newCollectionNameBtn.Click += new System.EventHandler(this.changeNameBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.filterBtn.FlatAppearance.BorderSize = 0;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Location = new System.Drawing.Point(883, 3);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(143, 23);
            this.filterBtn.TabIndex = 23;
            this.filterBtn.Text = "Filter Topics";
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // topicSearchTextBox
            // 
            this.topicSearchTextBox.Enabled = false;
            this.topicSearchTextBox.Location = new System.Drawing.Point(529, 29);
            this.topicSearchTextBox.Name = "topicSearchTextBox";
            this.topicSearchTextBox.Size = new System.Drawing.Size(143, 23);
            this.topicSearchTextBox.TabIndex = 24;
            this.topicSearchTextBox.Text = "";
            this.topicSearchTextBox.Visible = false;
            // 
            // topicTextBox
            // 
            this.topicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicTextBox.Location = new System.Drawing.Point(467, 29);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.ReadOnly = true;
            this.topicTextBox.Size = new System.Drawing.Size(56, 23);
            this.topicTextBox.TabIndex = 25;
            this.topicTextBox.Text = "Topic:";
            this.topicTextBox.Visible = false;
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keywordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordTextBox.Location = new System.Drawing.Point(678, 29);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.ReadOnly = true;
            this.keywordTextBox.Size = new System.Drawing.Size(61, 23);
            this.keywordTextBox.TabIndex = 26;
            this.keywordTextBox.Text = "Keyword:";
            this.keywordTextBox.Visible = false;
            // 
            // keywordSearchTextBox
            // 
            this.keywordSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keywordSearchTextBox.Location = new System.Drawing.Point(745, 29);
            this.keywordSearchTextBox.Name = "keywordSearchTextBox";
            this.keywordSearchTextBox.Size = new System.Drawing.Size(244, 23);
            this.keywordSearchTextBox.TabIndex = 27;
            this.keywordSearchTextBox.Text = "";
            this.keywordSearchTextBox.Visible = false;
            // 
            // searchTopicsBtn
            // 
            this.searchTopicsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTopicsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.searchTopicsBtn.Enabled = false;
            this.searchTopicsBtn.FlatAppearance.BorderSize = 0;
            this.searchTopicsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchTopicsBtn.Location = new System.Drawing.Point(995, 29);
            this.searchTopicsBtn.Name = "searchTopicsBtn";
            this.searchTopicsBtn.Size = new System.Drawing.Size(56, 23);
            this.searchTopicsBtn.TabIndex = 28;
            this.searchTopicsBtn.Text = "Search";
            this.searchTopicsBtn.UseVisualStyleBackColor = false;
            this.searchTopicsBtn.Visible = false;
            this.searchTopicsBtn.Click += new System.EventHandler(this.searchTopicsBtn_Click);
            // 
            // topicTreeView
            // 
            this.topicTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicTreeView.Enabled = false;
            this.topicTreeView.Location = new System.Drawing.Point(15, 60);
            this.topicTreeView.Name = "topicTreeView";
            this.topicTreeView.Size = new System.Drawing.Size(222, 534);
            this.topicTreeView.TabIndex = 29;
            this.topicTreeView.Visible = false;
            this.topicTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.topicTreeView_AfterSelect);
            // 
            // feedViewBtn
            // 
            this.feedViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.feedViewBtn.Enabled = false;
            this.feedViewBtn.FlatAppearance.BorderSize = 0;
            this.feedViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedViewBtn.Location = new System.Drawing.Point(883, 3);
            this.feedViewBtn.Name = "feedViewBtn";
            this.feedViewBtn.Size = new System.Drawing.Size(143, 23);
            this.feedViewBtn.TabIndex = 30;
            this.feedViewBtn.Text = "Feed View";
            this.feedViewBtn.UseVisualStyleBackColor = false;
            this.feedViewBtn.Visible = false;
            this.feedViewBtn.Click += new System.EventHandler(this.feedViewBtn_Click);
            // 
            // renameTextbox
            // 
            this.renameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.renameTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.renameTextbox.Enabled = false;
            this.renameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameTextbox.Location = new System.Drawing.Point(112, 3);
            this.renameTextbox.Name = "renameTextbox";
            this.renameTextbox.ReadOnly = true;
            this.renameTextbox.Size = new System.Drawing.Size(148, 33);
            this.renameTextbox.TabIndex = 33;
            this.renameTextbox.Text = "Rename Collection";
            this.renameTextbox.Visible = false;
            // 
            // renameCollectionEntry
            // 
            this.renameCollectionEntry.Enabled = false;
            this.renameCollectionEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameCollectionEntry.Location = new System.Drawing.Point(0, 38);
            this.renameCollectionEntry.Name = "renameCollectionEntry";
            this.renameCollectionEntry.Size = new System.Drawing.Size(372, 33);
            this.renameCollectionEntry.TabIndex = 34;
            this.renameCollectionEntry.Text = "";
            this.renameCollectionEntry.Visible = false;
            // 
            // confirmRenameBtn
            // 
            this.confirmRenameBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmRenameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.confirmRenameBtn.Enabled = false;
            this.confirmRenameBtn.FlatAppearance.BorderSize = 0;
            this.confirmRenameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmRenameBtn.Location = new System.Drawing.Point(3, 77);
            this.confirmRenameBtn.Name = "confirmRenameBtn";
            this.confirmRenameBtn.Size = new System.Drawing.Size(166, 23);
            this.confirmRenameBtn.TabIndex = 35;
            this.confirmRenameBtn.Text = "Confirm";
            this.confirmRenameBtn.UseVisualStyleBackColor = false;
            this.confirmRenameBtn.Visible = false;
            this.confirmRenameBtn.Click += new System.EventHandler(this.confirmRenameBtn_Click);
            // 
            // cancelRenameBtn
            // 
            this.cancelRenameBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelRenameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cancelRenameBtn.Enabled = false;
            this.cancelRenameBtn.FlatAppearance.BorderSize = 0;
            this.cancelRenameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelRenameBtn.Location = new System.Drawing.Point(193, 77);
            this.cancelRenameBtn.Name = "cancelRenameBtn";
            this.cancelRenameBtn.Size = new System.Drawing.Size(179, 23);
            this.cancelRenameBtn.TabIndex = 36;
            this.cancelRenameBtn.Text = "Cancel";
            this.cancelRenameBtn.UseVisualStyleBackColor = false;
            this.cancelRenameBtn.Visible = false;
            this.cancelRenameBtn.Click += new System.EventHandler(this.cancelRenameBtn_Click);
            // 
            // mapArticleTitle
            // 
            this.mapArticleTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mapArticleTitle.Enabled = false;
            this.mapArticleTitle.Location = new System.Drawing.Point(3, 3);
            this.mapArticleTitle.Name = "mapArticleTitle";
            this.mapArticleTitle.ReadOnly = true;
            this.mapArticleTitle.Size = new System.Drawing.Size(300, 39);
            this.mapArticleTitle.TabIndex = 37;
            this.mapArticleTitle.Text = "Title: ";
            this.mapArticleTitle.Visible = false;
            // 
            // mapArticleDesc
            // 
            this.mapArticleDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mapArticleDesc.Enabled = false;
            this.mapArticleDesc.Location = new System.Drawing.Point(3, 48);
            this.mapArticleDesc.Name = "mapArticleDesc";
            this.mapArticleDesc.ReadOnly = true;
            this.mapArticleDesc.Size = new System.Drawing.Size(300, 180);
            this.mapArticleDesc.TabIndex = 38;
            this.mapArticleDesc.Text = "Article Description: ";
            this.mapArticleDesc.Visible = false;
            // 
            // viewMapArticleBtn
            // 
            this.viewMapArticleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.viewMapArticleBtn.Enabled = false;
            this.viewMapArticleBtn.FlatAppearance.BorderSize = 0;
            this.viewMapArticleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMapArticleBtn.Location = new System.Drawing.Point(3, 234);
            this.viewMapArticleBtn.Name = "viewMapArticleBtn";
            this.viewMapArticleBtn.Size = new System.Drawing.Size(141, 23);
            this.viewMapArticleBtn.TabIndex = 39;
            this.viewMapArticleBtn.Text = "View Article";
            this.viewMapArticleBtn.UseVisualStyleBackColor = false;
            this.viewMapArticleBtn.Visible = false;
            this.viewMapArticleBtn.Click += new System.EventHandler(this.viewMapArticleBtn_Click);
            // 
            // closeMapArticleBtn
            // 
            this.closeMapArticleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.closeMapArticleBtn.Enabled = false;
            this.closeMapArticleBtn.FlatAppearance.BorderSize = 0;
            this.closeMapArticleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeMapArticleBtn.Location = new System.Drawing.Point(150, 234);
            this.closeMapArticleBtn.Name = "closeMapArticleBtn";
            this.closeMapArticleBtn.Size = new System.Drawing.Size(153, 23);
            this.closeMapArticleBtn.TabIndex = 40;
            this.closeMapArticleBtn.Text = "Close";
            this.closeMapArticleBtn.UseVisualStyleBackColor = false;
            this.closeMapArticleBtn.Visible = false;
            this.closeMapArticleBtn.Click += new System.EventHandler(this.closeMapArticleBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newCollectionBtn);
            this.panel1.Controls.Add(this.renameCollectionBtn);
            this.panel1.Controls.Add(this.cutFileBtn);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.urlSearchBar);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.feedViewBtn);
            this.panel1.Controls.Add(this.filterBtn);
            this.panel1.Controls.Add(this.closeMapBtn);
            this.panel1.Controls.Add(this.searchTopicsBtn);
            this.panel1.Controls.Add(this.topicTextBox);
            this.panel1.Controls.Add(this.keywordSearchTextBox);
            this.panel1.Controls.Add(this.topicSearchTextBox);
            this.panel1.Controls.Add(this.keywordTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 60);
            this.panel1.TabIndex = 41;
            // 
            // mapArticlePanel
            // 
            this.mapArticlePanel.Controls.Add(this.mapArticleTitle);
            this.mapArticlePanel.Controls.Add(this.mapArticleDesc);
            this.mapArticlePanel.Controls.Add(this.closeMapArticleBtn);
            this.mapArticlePanel.Controls.Add(this.viewMapArticleBtn);
            this.mapArticlePanel.Location = new System.Drawing.Point(284, 246);
            this.mapArticlePanel.Name = "mapArticlePanel";
            this.mapArticlePanel.Size = new System.Drawing.Size(306, 260);
            this.mapArticlePanel.TabIndex = 42;
            this.mapArticlePanel.Visible = false;
            // 
            // renamePanel
            // 
            this.renamePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.renamePanel.Controls.Add(this.renameCollectionEntry);
            this.renamePanel.Controls.Add(this.confirmRenameBtn);
            this.renamePanel.Controls.Add(this.cancelRenameBtn);
            this.renamePanel.Controls.Add(this.renameTextbox);
            this.renamePanel.Location = new System.Drawing.Point(12, 379);
            this.renamePanel.Name = "renamePanel";
            this.renamePanel.Size = new System.Drawing.Size(375, 109);
            this.renamePanel.TabIndex = 43;
            this.renamePanel.Visible = false;
            // 
            // newCollectionPanel
            // 
            this.newCollectionPanel.Controls.Add(this.collectionNamerTxtBox);
            this.newCollectionPanel.Controls.Add(this.newCollectionNameBtn);
            this.newCollectionPanel.Controls.Add(this.cancelColBtn);
            this.newCollectionPanel.Controls.Add(this.CollectionNameTxtBox);
            this.newCollectionPanel.Location = new System.Drawing.Point(15, 118);
            this.newCollectionPanel.Name = "newCollectionPanel";
            this.newCollectionPanel.Size = new System.Drawing.Size(335, 66);
            this.newCollectionPanel.TabIndex = 45;
            this.newCollectionPanel.Visible = false;
            // 
            // timeFilterPanel
            // 
            this.timeFilterPanel.Controls.Add(this.filterToTimeTxt);
            this.timeFilterPanel.Controls.Add(this.filterFromTxt);
            this.timeFilterPanel.Controls.Add(this.cancelFilterTimeBtn);
            this.timeFilterPanel.Controls.Add(this.filterByTimeBtn);
            this.timeFilterPanel.Controls.Add(this.toTextBox);
            this.timeFilterPanel.Controls.Add(this.fromTxtBox);
            this.timeFilterPanel.Controls.Add(this.timeFilterText);
            this.timeFilterPanel.Location = new System.Drawing.Point(745, 280);
            this.timeFilterPanel.Name = "timeFilterPanel";
            this.timeFilterPanel.Size = new System.Drawing.Size(243, 190);
            this.timeFilterPanel.TabIndex = 46;
            this.timeFilterPanel.Visible = false;
            // 
            // filterToTimeTxt
            // 
            this.filterToTimeTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.filterToTimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterToTimeTxt.Location = new System.Drawing.Point(58, 84);
            this.filterToTimeTxt.Name = "filterToTimeTxt";
            this.filterToTimeTxt.Size = new System.Drawing.Size(128, 29);
            this.filterToTimeTxt.TabIndex = 6;
            this.filterToTimeTxt.Text = "";
            this.filterToTimeTxt.Visible = false;
            // 
            // filterFromTxt
            // 
            this.filterFromTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.filterFromTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFromTxt.Location = new System.Drawing.Point(58, 38);
            this.filterFromTxt.Name = "filterFromTxt";
            this.filterFromTxt.Size = new System.Drawing.Size(128, 29);
            this.filterFromTxt.TabIndex = 5;
            this.filterFromTxt.Text = "";
            this.filterFromTxt.Visible = false;
            // 
            // cancelFilterTimeBtn
            // 
            this.cancelFilterTimeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cancelFilterTimeBtn.FlatAppearance.BorderSize = 0;
            this.cancelFilterTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelFilterTimeBtn.Location = new System.Drawing.Point(128, 147);
            this.cancelFilterTimeBtn.Name = "cancelFilterTimeBtn";
            this.cancelFilterTimeBtn.Size = new System.Drawing.Size(112, 23);
            this.cancelFilterTimeBtn.TabIndex = 4;
            this.cancelFilterTimeBtn.Text = "Cancel";
            this.cancelFilterTimeBtn.UseVisualStyleBackColor = false;
            this.cancelFilterTimeBtn.Visible = false;
            this.cancelFilterTimeBtn.Click += new System.EventHandler(this.cancelFilterTimeBtn_Click);
            // 
            // filterByTimeBtn
            // 
            this.filterByTimeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.filterByTimeBtn.FlatAppearance.BorderSize = 0;
            this.filterByTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterByTimeBtn.Location = new System.Drawing.Point(3, 147);
            this.filterByTimeBtn.Name = "filterByTimeBtn";
            this.filterByTimeBtn.Size = new System.Drawing.Size(112, 23);
            this.filterByTimeBtn.TabIndex = 3;
            this.filterByTimeBtn.Text = "Filter";
            this.filterByTimeBtn.UseVisualStyleBackColor = false;
            this.filterByTimeBtn.Visible = false;
            this.filterByTimeBtn.Click += new System.EventHandler(this.filterByTimeBtn_Click);
            // 
            // toTextBox
            // 
            this.toTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTextBox.Location = new System.Drawing.Point(0, 84);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.ReadOnly = true;
            this.toTextBox.Size = new System.Drawing.Size(52, 29);
            this.toTextBox.TabIndex = 2;
            this.toTextBox.Text = "To";
            this.toTextBox.Visible = false;
            // 
            // fromTxtBox
            // 
            this.fromTxtBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fromTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTxtBox.Location = new System.Drawing.Point(0, 38);
            this.fromTxtBox.Name = "fromTxtBox";
            this.fromTxtBox.ReadOnly = true;
            this.fromTxtBox.Size = new System.Drawing.Size(52, 29);
            this.fromTxtBox.TabIndex = 1;
            this.fromTxtBox.Text = "From";
            this.fromTxtBox.Visible = false;
            // 
            // timeFilterText
            // 
            this.timeFilterText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.timeFilterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFilterText.Location = new System.Drawing.Point(50, 3);
            this.timeFilterText.Name = "timeFilterText";
            this.timeFilterText.ReadOnly = true;
            this.timeFilterText.Size = new System.Drawing.Size(136, 29);
            this.timeFilterText.TabIndex = 0;
            this.timeFilterText.Text = "Filter articles by Time";
            this.timeFilterText.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(240, 280);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(749, 314);
            this.webBrowser1.TabIndex = 47;
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Enabled = false;
            this.elementHost1.Location = new System.Drawing.Point(240, 118);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(749, 476);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Visible = false;
            this.elementHost1.Child = this.userControl11;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1129, 606);
            this.Controls.Add(this.mapArticlePanel);
            this.Controls.Add(this.timeFilterPanel);
            this.Controls.Add(this.renamePanel);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.newCollectionPanel);
            this.Controls.Add(this.mapFeed);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.feedViewer);
            this.Controls.Add(this.topicTreeView);
            this.Controls.Add(this.articleViewer);
            this.Controls.Add(this.elementHost1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainInterface";
            this.Text = "MapRSS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mapArticlePanel.ResumeLayout(false);
            this.renamePanel.ResumeLayout(false);
            this.newCollectionPanel.ResumeLayout(false);
            this.timeFilterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private UserControl1 userControl11;
        private System.Windows.Forms.ListView articleViewer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMapToolStripMenuItem;
        private System.Windows.Forms.Button closeMapBtn;
        private System.Windows.Forms.TreeView feedViewer;
        private System.Windows.Forms.Button newCollectionBtn;
        private System.Windows.Forms.Button renameCollectionBtn;
        private System.Windows.Forms.Button cutFileBtn;
        private System.Windows.Forms.RichTextBox mapFeed;
        private System.Windows.Forms.TextBox urlSearchBar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button cancelColBtn;
        private System.Windows.Forms.RichTextBox collectionNamerTxtBox;
        private System.Windows.Forms.RichTextBox CollectionNameTxtBox;
        private System.Windows.Forms.Button newCollectionNameBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.RichTextBox topicSearchTextBox;
        private System.Windows.Forms.RichTextBox topicTextBox;
        private System.Windows.Forms.RichTextBox keywordTextBox;
        private System.Windows.Forms.RichTextBox keywordSearchTextBox;
        private System.Windows.Forms.Button searchTopicsBtn;
        private System.Windows.Forms.TreeView topicTreeView;
        private System.Windows.Forms.Button feedViewBtn;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem feedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topicsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolStripMenuItem filterByTimeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox renameTextbox;
        private System.Windows.Forms.RichTextBox renameCollectionEntry;
        private System.Windows.Forms.Button confirmRenameBtn;
        private System.Windows.Forms.Button cancelRenameBtn;
        private System.Windows.Forms.RichTextBox mapArticleTitle;
        private System.Windows.Forms.RichTextBox mapArticleDesc;
        private System.Windows.Forms.Button viewMapArticleBtn;
        private System.Windows.Forms.Button closeMapArticleBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mapArticlePanel;
        private System.Windows.Forms.Panel renamePanel;
        private System.Windows.Forms.Panel newCollectionPanel;
        private System.Windows.Forms.Panel timeFilterPanel;
        private System.Windows.Forms.RichTextBox timeFilterText;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox filterToTimeTxt;
        private System.Windows.Forms.RichTextBox filterFromTxt;
        private System.Windows.Forms.Button cancelFilterTimeBtn;
        private System.Windows.Forms.Button filterByTimeBtn;
        private System.Windows.Forms.RichTextBox toTextBox;
        private System.Windows.Forms.RichTextBox fromTxtBox;
    }
}

