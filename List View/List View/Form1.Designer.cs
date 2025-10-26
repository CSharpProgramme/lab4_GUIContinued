namespace List_View
{
    partial class ListViewTestForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewTestForm));
            this.browserListView = new System.Windows.Forms.ListView();
            this.fileFolderImageList = new System.Windows.Forms.ImageList(this.components);
            this.displayLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browserListView
            // 
            this.browserListView.FullRowSelect = true;
            this.browserListView.HideSelection = false;
            this.browserListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.browserListView.LargeImageList = this.fileFolderImageList;
            this.browserListView.Location = new System.Drawing.Point(122, 70);
            this.browserListView.Name = "browserListView";
            this.browserListView.Size = new System.Drawing.Size(546, 308);
            this.browserListView.SmallImageList = this.fileFolderImageList;
            this.browserListView.TabIndex = 0;
            this.browserListView.UseCompatibleStateImageBehavior = false;
            this.browserListView.View = System.Windows.Forms.View.List;
            this.browserListView.Click += new System.EventHandler(this.browserListView_Click);
            // 
            // fileFolderImageList
            // 
            this.fileFolderImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileFolderImageList.ImageStream")));
            this.fileFolderImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileFolderImageList.Images.SetKeyName(0, "file.bmp");
            this.fileFolderImageList.Images.SetKeyName(1, "folder.bmp");
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(176, 47);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayLabel.TabIndex = 1;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(119, 47);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "Location:";
            // 
            // ListViewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.browserListView);
            this.Name = "ListViewTestForm";
            this.Text = "List View";
            this.Load += new System.EventHandler(this.ListViewTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView browserListView;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.ImageList fileFolderImageList;
        private System.Windows.Forms.Label locationLabel;
    }
}

