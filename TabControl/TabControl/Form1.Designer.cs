namespace TabControl
{
    partial class tabControlForm
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.fontModificationtabControl = new System.Windows.Forms.TabControl();
            this.colorTabPage = new System.Windows.Forms.TabPage();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeTabPage = new System.Windows.Forms.TabPage();
            this.messageTabPage = new System.Windows.Forms.TabPage();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.radioButtonPoint12 = new System.Windows.Forms.RadioButton();
            this.radioButtonPoint16 = new System.Windows.Forms.RadioButton();
            this.radioButtonPoint20 = new System.Windows.Forms.RadioButton();
            this.radioButtonHello = new System.Windows.Forms.RadioButton();
            this.radioButtonGoodBye = new System.Windows.Forms.RadioButton();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.fontModificationtabControl.SuspendLayout();
            this.colorTabPage.SuspendLayout();
            this.sizeTabPage.SuspendLayout();
            this.messageTabPage.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(113, 210);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(35, 13);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "label1";
            // 
            // fontModificationtabControl
            // 
            this.fontModificationtabControl.Controls.Add(this.colorTabPage);
            this.fontModificationtabControl.Controls.Add(this.sizeTabPage);
            this.fontModificationtabControl.Controls.Add(this.messageTabPage);
            this.fontModificationtabControl.Controls.Add(this.aboutTabPage);
            this.fontModificationtabControl.Location = new System.Drawing.Point(35, 48);
            this.fontModificationtabControl.Name = "fontModificationtabControl";
            this.fontModificationtabControl.SelectedIndex = 0;
            this.fontModificationtabControl.Size = new System.Drawing.Size(230, 146);
            this.fontModificationtabControl.TabIndex = 2;
            // 
            // colorTabPage
            // 
            this.colorTabPage.Controls.Add(this.greenRadioButton);
            this.colorTabPage.Controls.Add(this.redRadioButton);
            this.colorTabPage.Controls.Add(this.blackRadioButton);
            this.colorTabPage.Location = new System.Drawing.Point(4, 22);
            this.colorTabPage.Name = "colorTabPage";
            this.colorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.colorTabPage.Size = new System.Drawing.Size(222, 120);
            this.colorTabPage.TabIndex = 0;
            this.colorTabPage.Text = "Color";
            this.colorTabPage.UseVisualStyleBackColor = true;
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(6, 52);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(6, 29);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(6, 6);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackRadioButton.TabIndex = 0;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // sizeTabPage
            // 
            this.sizeTabPage.Controls.Add(this.radioButtonPoint20);
            this.sizeTabPage.Controls.Add(this.radioButtonPoint16);
            this.sizeTabPage.Controls.Add(this.radioButtonPoint12);
            this.sizeTabPage.Location = new System.Drawing.Point(4, 22);
            this.sizeTabPage.Name = "sizeTabPage";
            this.sizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sizeTabPage.Size = new System.Drawing.Size(222, 120);
            this.sizeTabPage.TabIndex = 1;
            this.sizeTabPage.Text = "Size";
            this.sizeTabPage.UseVisualStyleBackColor = true;
            // 
            // messageTabPage
            // 
            this.messageTabPage.Controls.Add(this.radioButtonGoodBye);
            this.messageTabPage.Controls.Add(this.radioButtonHello);
            this.messageTabPage.Location = new System.Drawing.Point(4, 22);
            this.messageTabPage.Name = "messageTabPage";
            this.messageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.messageTabPage.Size = new System.Drawing.Size(222, 120);
            this.messageTabPage.TabIndex = 2;
            this.messageTabPage.Text = "Message";
            this.messageTabPage.UseVisualStyleBackColor = true;
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.aboutLabel);
            this.aboutTabPage.Location = new System.Drawing.Point(4, 22);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTabPage.Size = new System.Drawing.Size(222, 120);
            this.aboutTabPage.TabIndex = 3;
            this.aboutTabPage.Text = "About";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // radioButtonPoint12
            // 
            this.radioButtonPoint12.AutoSize = true;
            this.radioButtonPoint12.Location = new System.Drawing.Point(6, 6);
            this.radioButtonPoint12.Name = "radioButtonPoint12";
            this.radioButtonPoint12.Size = new System.Drawing.Size(64, 17);
            this.radioButtonPoint12.TabIndex = 0;
            this.radioButtonPoint12.TabStop = true;
            this.radioButtonPoint12.Text = "12 Point";
            this.radioButtonPoint12.UseVisualStyleBackColor = true;
            this.radioButtonPoint12.CheckedChanged += new System.EventHandler(this.radioButtonPoint12_CheckedChanged);
            // 
            // radioButtonPoint16
            // 
            this.radioButtonPoint16.AutoSize = true;
            this.radioButtonPoint16.Location = new System.Drawing.Point(6, 29);
            this.radioButtonPoint16.Name = "radioButtonPoint16";
            this.radioButtonPoint16.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPoint16.TabIndex = 1;
            this.radioButtonPoint16.TabStop = true;
            this.radioButtonPoint16.Text = "16 Point ";
            this.radioButtonPoint16.UseVisualStyleBackColor = true;
            this.radioButtonPoint16.CheckedChanged += new System.EventHandler(this.radioButtonPoint16_CheckedChanged);
            // 
            // radioButtonPoint20
            // 
            this.radioButtonPoint20.AutoSize = true;
            this.radioButtonPoint20.Location = new System.Drawing.Point(6, 52);
            this.radioButtonPoint20.Name = "radioButtonPoint20";
            this.radioButtonPoint20.Size = new System.Drawing.Size(64, 17);
            this.radioButtonPoint20.TabIndex = 2;
            this.radioButtonPoint20.TabStop = true;
            this.radioButtonPoint20.Text = "20 Point";
            this.radioButtonPoint20.UseVisualStyleBackColor = true;
            this.radioButtonPoint20.CheckedChanged += new System.EventHandler(this.radioButtonPoint20_CheckedChanged);
            // 
            // radioButtonHello
            // 
            this.radioButtonHello.AutoSize = true;
            this.radioButtonHello.Location = new System.Drawing.Point(6, 6);
            this.radioButtonHello.Name = "radioButtonHello";
            this.radioButtonHello.Size = new System.Drawing.Size(52, 17);
            this.radioButtonHello.TabIndex = 0;
            this.radioButtonHello.TabStop = true;
            this.radioButtonHello.Text = "Hello!";
            this.radioButtonHello.UseVisualStyleBackColor = true;
            this.radioButtonHello.CheckedChanged += new System.EventHandler(this.radioButtonHello_CheckedChanged);
            // 
            // radioButtonGoodBye
            // 
            this.radioButtonGoodBye.AutoSize = true;
            this.radioButtonGoodBye.Location = new System.Drawing.Point(6, 29);
            this.radioButtonGoodBye.Name = "radioButtonGoodBye";
            this.radioButtonGoodBye.Size = new System.Drawing.Size(71, 17);
            this.radioButtonGoodBye.TabIndex = 1;
            this.radioButtonGoodBye.TabStop = true;
            this.radioButtonGoodBye.Text = "Goodbye!";
            this.radioButtonGoodBye.UseVisualStyleBackColor = true;
            this.radioButtonGoodBye.CheckedChanged += new System.EventHandler(this.radioButtonGoodBye_CheckedChanged);
            // 
            // aboutLabel
            // 
            this.aboutLabel.Location = new System.Drawing.Point(6, 17);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(213, 38);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Tabs are used to organize controls and conserve screen space";
            // 
            // tabControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 270);
            this.Controls.Add(this.fontModificationtabControl);
            this.Controls.Add(this.displayLabel);
            this.Name = "tabControlForm";
            this.Text = "Tab Control";
            this.fontModificationtabControl.ResumeLayout(false);
            this.colorTabPage.ResumeLayout(false);
            this.colorTabPage.PerformLayout();
            this.sizeTabPage.ResumeLayout(false);
            this.sizeTabPage.PerformLayout();
            this.messageTabPage.ResumeLayout(false);
            this.messageTabPage.PerformLayout();
            this.aboutTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.TabControl fontModificationtabControl;
        private System.Windows.Forms.TabPage colorTabPage;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.TabPage sizeTabPage;
        private System.Windows.Forms.TabPage messageTabPage;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.RadioButton radioButtonPoint20;
        private System.Windows.Forms.RadioButton radioButtonPoint16;
        private System.Windows.Forms.RadioButton radioButtonPoint12;
        private System.Windows.Forms.RadioButton radioButtonGoodBye;
        private System.Windows.Forms.RadioButton radioButtonHello;
        private System.Windows.Forms.Label aboutLabel;
    }
}

