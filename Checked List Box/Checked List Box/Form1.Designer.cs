namespace Checked_List_Box
{
    partial class checkedListBox
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
            this.itemCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // itemCheckedListBox
            // 
            this.itemCheckedListBox.FormattingEnabled = true;
            this.itemCheckedListBox.Items.AddRange(new object[] {
            "C HTP",
            "C++ HTP",
            "Internet & WWW HTP",
            "Java HTP",
            "Visual Basic HTP",
            "Visual C++ HTP",
            "Visual C# HTP"});
            this.itemCheckedListBox.Location = new System.Drawing.Point(90, 97);
            this.itemCheckedListBox.Name = "itemCheckedListBox";
            this.itemCheckedListBox.Size = new System.Drawing.Size(138, 169);
            this.itemCheckedListBox.TabIndex = 0;
            this.itemCheckedListBox.Tag = "";
            this.itemCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.itemCheckedListBox_ItemCheck);
            this.itemCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.itemCheckedListBox_SelectedIndexChanged);
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(247, 97);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(137, 173);
            this.displayListBox.TabIndex = 1;
            // 
            // checkedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 395);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.itemCheckedListBox);
            this.Name = "checkedListBox";
            this.Text = "Checked List Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox itemCheckedListBox;
        private System.Windows.Forms.ListBox displayListBox;
    }
}

