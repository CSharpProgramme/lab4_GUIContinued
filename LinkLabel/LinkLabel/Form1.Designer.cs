namespace LinkLabel
{
    partial class LinkLabel
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
            this.cDriveLinkLabel = new System.Windows.Forms.LinkLabel();
            this.youtubeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.notepadLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cDriveLinkLabel
            // 
            this.cDriveLinkLabel.AutoSize = true;
            this.cDriveLinkLabel.Location = new System.Drawing.Point(36, 41);
            this.cDriveLinkLabel.Name = "cDriveLinkLabel";
            this.cDriveLinkLabel.Size = new System.Drawing.Size(98, 13);
            this.cDriveLinkLabel.TabIndex = 0;
            this.cDriveLinkLabel.TabStop = true;
            this.cDriveLinkLabel.Text = "Click to Browse C:\\";
            this.cDriveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cDriveLinkLabel_LinkClicked);
            // 
            // youtubeLinkLabel
            // 
            this.youtubeLinkLabel.AutoSize = true;
            this.youtubeLinkLabel.Location = new System.Drawing.Point(36, 83);
            this.youtubeLinkLabel.Name = "youtubeLinkLabel";
            this.youtubeLinkLabel.Size = new System.Drawing.Size(154, 13);
            this.youtubeLinkLabel.TabIndex = 1;
            this.youtubeLinkLabel.TabStop = true;
            this.youtubeLinkLabel.Text = "Click to visit www.youtube.com";
            this.youtubeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.youtubeLinkLabel_LinkClicked);
            // 
            // notepadLinkLabel
            // 
            this.notepadLinkLabel.AutoSize = true;
            this.notepadLinkLabel.Location = new System.Drawing.Point(36, 126);
            this.notepadLinkLabel.Name = "notepadLinkLabel";
            this.notepadLinkLabel.Size = new System.Drawing.Size(104, 13);
            this.notepadLinkLabel.TabIndex = 2;
            this.notepadLinkLabel.TabStop = true;
            this.notepadLinkLabel.Text = "Click to run Notepad";
            this.notepadLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notepadLinkLabel_LinkClicked);
            // 
            // LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 199);
            this.Controls.Add(this.notepadLinkLabel);
            this.Controls.Add(this.youtubeLinkLabel);
            this.Controls.Add(this.cDriveLinkLabel);
            this.Name = "LinkLabel";
            this.Text = "Link Label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel cDriveLinkLabel;
        private System.Windows.Forms.LinkLabel youtubeLinkLabel;
        private System.Windows.Forms.LinkLabel notepadLinkLabel;
    }
}

