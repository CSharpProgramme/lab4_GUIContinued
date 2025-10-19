using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkLabel
{
    public partial class LinkLabel : Form
    {
        public LinkLabel()
        {
            InitializeComponent();
        }

        private void cDriveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //change LinkColor after it has been clicked
            cDriveLinkLabel.LinkVisited = true;

            System.Diagnostics.Process.Start(@"C:\");
        }

        //load www.youtube.com in web browser
        private void youtubeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            youtubeLinkLabel.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        //run app notepad
        private void notepadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            notepadLinkLabel.LinkVisited = true;

            System.Diagnostics.Process.Start("notepad");
        }
    }
}
