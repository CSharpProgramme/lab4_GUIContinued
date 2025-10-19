namespace Combo_Box
{
    partial class comboBox
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
            this.imageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // imageComboBox
            // 
            this.imageComboBox.FormattingEnabled = true;
            this.imageComboBox.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Ellipse",
            "Pie",
            "Filled Cicle",
            "Filled Rectangle",
            "Filled Ellipse",
            "Filled Pie"});
            this.imageComboBox.Location = new System.Drawing.Point(12, 12);
            this.imageComboBox.Name = "imageComboBox";
            this.imageComboBox.Size = new System.Drawing.Size(159, 21);
            this.imageComboBox.TabIndex = 0;
            this.imageComboBox.SelectedIndexChanged += new System.EventHandler(this.imageComboBox_SelectedIndexChanged);
            // 
            // comboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 330);
            this.Controls.Add(this.imageComboBox);
            this.Name = "comboBox";
            this.Text = "Combo Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox imageComboBox;
    }
}

