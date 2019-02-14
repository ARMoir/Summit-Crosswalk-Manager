namespace Summit_Crosswalk_Manager
{
    partial class Summit_Crosswalk_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summit_Crosswalk_Manager));
            this.ConnectionStrings = new System.Windows.Forms.ComboBox();
            this.Tables = new System.Windows.Forms.ComboBox();
            this.AddConection = new System.Windows.Forms.Button();
            this.RefreshTables = new System.Windows.Forms.Button();
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
            this.MainMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Download = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.BottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.UserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UserTXT = new System.Windows.Forms.ToolStripStatusLabel();
            this.RowLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RowCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColumnLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColumnCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.SourceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SourceTXT = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainProBar = new System.Windows.Forms.ToolStripProgressBar();
            this.Next = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.Current = new System.Windows.Forms.Label();
            this.Last = new System.Windows.Forms.Button();
            this.Logs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.BottomStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionStrings
            // 
            this.ConnectionStrings.FormattingEnabled = true;
            this.ConnectionStrings.Location = new System.Drawing.Point(12, 12);
            this.ConnectionStrings.Name = "ConnectionStrings";
            this.ConnectionStrings.Size = new System.Drawing.Size(609, 24);
            this.ConnectionStrings.TabIndex = 0;
            this.ConnectionStrings.Text = "Database";
            this.ConnectionStrings.SelectedIndexChanged += new System.EventHandler(this.ConnectionStrings_SelectedIndexChanged);
            // 
            // Tables
            // 
            this.Tables.FormattingEnabled = true;
            this.Tables.Location = new System.Drawing.Point(12, 44);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(609, 24);
            this.Tables.TabIndex = 1;
            this.Tables.Text = "Table";
            // 
            // AddConection
            // 
            this.AddConection.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.AddConection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddConection.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Add;
            this.AddConection.Location = new System.Drawing.Point(627, 12);
            this.AddConection.Name = "AddConection";
            this.AddConection.Size = new System.Drawing.Size(31, 25);
            this.AddConection.TabIndex = 2;
            this.AddConection.UseVisualStyleBackColor = true;
            this.AddConection.Click += new System.EventHandler(this.AddConection_Click);
            // 
            // RefreshTables
            // 
            this.RefreshTables.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.RefreshTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshTables.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Refresh;
            this.RefreshTables.Location = new System.Drawing.Point(627, 44);
            this.RefreshTables.Name = "RefreshTables";
            this.RefreshTables.Size = new System.Drawing.Size(31, 24);
            this.RefreshTables.TabIndex = 3;
            this.RefreshTables.UseVisualStyleBackColor = true;
            this.RefreshTables.Click += new System.EventHandler(this.RefreshTables_Click);
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainDataGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.MainDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.ContextMenuStrip = this.MainMenuStrip;
            this.MainDataGrid.GridColor = System.Drawing.Color.Lavender;
            this.MainDataGrid.Location = new System.Drawing.Point(12, 74);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.RowTemplate.Height = 24;
            this.MainDataGrid.Size = new System.Drawing.Size(991, 347);
            this.MainDataGrid.TabIndex = 4;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(129, 82);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Download
            // 
            this.Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Download.AutoSize = true;
            this.Download.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Download.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Download.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Download;
            this.Download.Location = new System.Drawing.Point(1009, 74);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(121, 108);
            this.Download.TabIndex = 5;
            this.Download.Text = "Download";
            this.Download.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Upload
            // 
            this.Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Upload.AutoSize = true;
            this.Upload.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.Upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Upload.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Upload.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Upload;
            this.Upload.Location = new System.Drawing.Point(1009, 313);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(121, 108);
            this.Upload.TabIndex = 6;
            this.Upload.Text = "Upload";
            this.Upload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Import
            // 
            this.Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Import.AutoSize = true;
            this.Import.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Import.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Import.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Import;
            this.Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Import.Location = new System.Drawing.Point(292, 427);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(134, 77);
            this.Import.TabIndex = 7;
            this.Import.Text = "Import";
            this.Import.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Export.AutoSize = true;
            this.Export.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Export.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Export.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Save;
            this.Export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Export.Location = new System.Drawing.Point(152, 427);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(134, 77);
            this.Export.TabIndex = 8;
            this.Export.Text = "Export";
            this.Export.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Paste
            // 
            this.Paste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Paste.AutoSize = true;
            this.Paste.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.Paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paste.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Paste.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Paste;
            this.Paste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Paste.Location = new System.Drawing.Point(12, 427);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(134, 77);
            this.Paste.TabIndex = 9;
            this.Paste.Text = "Paste";
            this.Paste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Search;
            this.SearchButton.Location = new System.Drawing.Point(972, 427);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(31, 23);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // SearchBox
            // 
            this.SearchBox.AcceptsReturn = true;
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SearchBox.Location = new System.Drawing.Point(868, 427);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(98, 22);
            this.SearchBox.TabIndex = 12;
            // 
            // BottomStatusStrip
            // 
            this.BottomStatusStrip.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.BottomStatusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserLabel,
            this.UserTXT,
            this.RowLabel,
            this.RowCount,
            this.ColumnLabel,
            this.ColumnCount,
            this.SourceLabel,
            this.SourceTXT,
            this.ProgressLabel,
            this.MainProBar});
            this.BottomStatusStrip.Location = new System.Drawing.Point(0, 508);
            this.BottomStatusStrip.Name = "BottomStatusStrip";
            this.BottomStatusStrip.Size = new System.Drawing.Size(1142, 25);
            this.BottomStatusStrip.TabIndex = 13;
            this.BottomStatusStrip.Text = "BottomStatusStrip";
            // 
            // UserLabel
            // 
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(41, 20);
            this.UserLabel.Text = "User:";
            // 
            // UserTXT
            // 
            this.UserTXT.BackColor = System.Drawing.Color.Transparent;
            this.UserTXT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UserTXT.Name = "UserTXT";
            this.UserTXT.Size = new System.Drawing.Size(97, 20);
            this.UserTXT.Text = "Domain/User";
            // 
            // RowLabel
            // 
            this.RowLabel.BackColor = System.Drawing.Color.Transparent;
            this.RowLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(47, 20);
            this.RowLabel.Text = "Rows:";
            // 
            // RowCount
            // 
            this.RowCount.BackColor = System.Drawing.Color.Transparent;
            this.RowCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RowCount.Name = "RowCount";
            this.RowCount.Size = new System.Drawing.Size(17, 20);
            this.RowCount.Text = "0";
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.BackColor = System.Drawing.Color.Transparent;
            this.ColumnLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(69, 20);
            this.ColumnLabel.Text = "Columns:";
            // 
            // ColumnCount
            // 
            this.ColumnCount.BackColor = System.Drawing.Color.Transparent;
            this.ColumnCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.Size = new System.Drawing.Size(17, 20);
            this.ColumnCount.Text = "0";
            // 
            // SourceLabel
            // 
            this.SourceLabel.BackColor = System.Drawing.Color.Transparent;
            this.SourceLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(57, 20);
            this.SourceLabel.Text = "Source:";
            // 
            // SourceTXT
            // 
            this.SourceTXT.BackColor = System.Drawing.Color.Transparent;
            this.SourceTXT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SourceTXT.Name = "SourceTXT";
            this.SourceTXT.Size = new System.Drawing.Size(50, 20);
            this.SourceTXT.Text = "NONE";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProgressLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(68, 20);
            this.ProgressLabel.Text = "Progress:";
            // 
            // MainProBar
            // 
            this.MainProBar.BackColor = System.Drawing.Color.Lavender;
            this.MainProBar.Name = "MainProBar";
            this.MainProBar.Size = new System.Drawing.Size(100, 19);
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Paste;
            this.Next.Location = new System.Drawing.Point(920, 477);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(46, 23);
            this.Next.TabIndex = 14;
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Total.Location = new System.Drawing.Point(917, 457);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 17);
            this.Total.TabIndex = 15;
            // 
            // Current
            // 
            this.Current.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Current.AutoSize = true;
            this.Current.BackColor = System.Drawing.Color.Transparent;
            this.Current.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Current.Location = new System.Drawing.Point(868, 457);
            this.Current.Name = "Current";
            this.Current.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Current.Size = new System.Drawing.Size(0, 17);
            this.Current.TabIndex = 16;
            this.Current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Last
            // 
            this.Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Last.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.Last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Last.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Last;
            this.Last.Location = new System.Drawing.Point(868, 477);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(46, 23);
            this.Last.TabIndex = 18;
            this.Last.UseVisualStyleBackColor = true;
            this.Last.Click += new System.EventHandler(this.Last_Click);
            // 
            // Logs
            // 
            this.Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logs.AutoSize = true;
            this.Logs.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.Logs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Logs.Image = global::Summit_Crosswalk_Manager.Properties.Resources.Audit;
            this.Logs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logs.Location = new System.Drawing.Point(432, 428);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(134, 77);
            this.Logs.TabIndex = 19;
            this.Logs.Text = "Audit Log";
            this.Logs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logs.UseVisualStyleBackColor = true;
            this.Logs.Click += new System.EventHandler(this.Logs_Click);
            // 
            // Summit_Crosswalk_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Summit_Crosswalk_Manager.Properties.Resources.MoneyTwins;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 533);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.BottomStatusStrip);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.MainDataGrid);
            this.Controls.Add(this.RefreshTables);
            this.Controls.Add(this.AddConection);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.ConnectionStrings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Summit_Crosswalk_Manager";
            this.Text = "Summit Crosswalk Manager";
            this.Load += new System.EventHandler(this.Summit_Crosswalk_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.BottomStatusStrip.ResumeLayout(false);
            this.BottomStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ConnectionStrings;
        private System.Windows.Forms.ComboBox Tables;
        private System.Windows.Forms.Button AddConection;
        private System.Windows.Forms.Button RefreshTables;
        private System.Windows.Forms.DataGridView MainDataGrid;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.StatusStrip BottomStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
        private System.Windows.Forms.ToolStripProgressBar MainProBar;
        private System.Windows.Forms.ToolStripStatusLabel RowLabel;
        private System.Windows.Forms.ToolStripStatusLabel RowCount;
        private System.Windows.Forms.ToolStripStatusLabel ColumnLabel;
        private System.Windows.Forms.ToolStripStatusLabel ColumnCount;
        private System.Windows.Forms.ToolStripStatusLabel SourceLabel;
        private System.Windows.Forms.ToolStripStatusLabel SourceTXT;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Current;
        private System.Windows.Forms.Button Last;
        private System.Windows.Forms.Button Logs;
        private System.Windows.Forms.ToolStripStatusLabel UserLabel;
        private System.Windows.Forms.ToolStripStatusLabel UserTXT;
        private System.Windows.Forms.ContextMenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Button SearchButton;
    }
}

