namespace VisualInheritanceBase
{
    partial class VisualInheritanceForm
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
            this.bugsLabel = new System.Windows.Forms.Label();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.learnMoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bugsLabel
            // 
            this.bugsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bugsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugsLabel.Location = new System.Drawing.Point(46, 43);
            this.bugsLabel.Name = "bugsLabel";
            this.bugsLabel.Size = new System.Drawing.Size(240, 23);
            this.bugsLabel.TabIndex = 0;
            this.bugsLabel.Text = "Bugs, Bugs, Bugs";
            this.bugsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRightLabel.Location = new System.Drawing.Point(46, 146);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(240, 17);
            this.copyRightLabel.TabIndex = 1;
            this.copyRightLabel.Text = "Copy - right 2017, by Deitel & Associates, Inc";
            this.copyRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // learnMoreButton
            // 
            this.learnMoreButton.Location = new System.Drawing.Point(46, 79);
            this.learnMoreButton.Name = "learnMoreButton";
            this.learnMoreButton.Size = new System.Drawing.Size(112, 46);
            this.learnMoreButton.TabIndex = 2;
            this.learnMoreButton.Text = "Learn More";
            this.learnMoreButton.UseVisualStyleBackColor = true;
            this.learnMoreButton.Click += new System.EventHandler(this.learnMoreButton_Click);
            // 
            // VisualInheritanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 206);
            this.Controls.Add(this.learnMoreButton);
            this.Controls.Add(this.copyRightLabel);
            this.Controls.Add(this.bugsLabel);
            this.Name = "VisualInheritanceForm";
            this.Text = "Visual Inheritance Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label bugsLabel;
        public System.Windows.Forms.Label copyRightLabel;
        public System.Windows.Forms.Button learnMoreButton;
    }
}

