using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuTestApp
{
    public partial class MenuTestForm : Form
    {
        public MenuTestForm()
        {
            InitializeComponent();
        }

        //display MessageBox when About ToolStripMenuItem is selected
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app using menu to show different choices.", "app design by steve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //exit program when Exit ToolStripMenuItem is selected
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //reset checkmarks for color toolStripMenuItems
        private void clearColorCheckMark()
        {
            //clear all checkmarks
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
        }

        //update menu state and color display black
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear whatever color was checked before this current color
            clearColorCheckMark();
            msgLabel.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;//adds check mark to show current color is selected
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColorCheckMark();
            msgLabel.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColorCheckMark();
            msgLabel.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColorCheckMark();
            msgLabel.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void clearFontStyle()
        {
            courrierToolStripMenuItem.Checked = false;
            commisSansToolStripMenuItem.Checked = false;
            timesNewRomanToolStripMenuItem.Checked = false;
        }

        private void courrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFontStyle();
            courrierToolStripMenuItem.Checked = true;
            msgLabel.Font = new Font("Courrier", 14, Font.Style);
        }

        private void commisSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFontStyle();
            commisSansToolStripMenuItem.Checked = true;
            msgLabel.Font = new Font("Comic Sans MS", 14, Font.Style);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFontStyle();
            timesNewRomanToolStripMenuItem.Checked = true;
            msgLabel.Font = new Font("Times New Roman", 14, Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toggle checkmark
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            //use XOR to toggle bold, keep all other styles
            msgLabel.Font = new Font(msgLabel.Font, msgLabel.Font.Style ^ FontStyle.Bold);

        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;//removes the check mark when click again
            msgLabel.Font = new Font(msgLabel.Font, msgLabel.Font.Style ^ FontStyle.Italic);
        }



        //we can do this in the properties too, set checked to true
        //private void MenuTestForm_Load(object sender, EventArgs e)
        //{
        //    blackToolStripMenuItem.Checked = true;//set the inital color to checked
        //}


    }
}
