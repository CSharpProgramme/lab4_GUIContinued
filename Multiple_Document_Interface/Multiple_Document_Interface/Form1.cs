using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Document_Interface
{
    public partial class mdiForm : Form
    {
        public mdiForm()
        {
            InitializeComponent();
        }

        private void lavenderFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create new child
            var lavenderChild = new ChildForm("Lavender Flowers", "lavenderflowers");
            lavenderChild.MdiParent = this;//set parent
            lavenderChild.Show();//display child
        }

        private void purpleFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var purpleChild = new ChildForm("Purple FLowers", "purpleflowers");
            purpleChild.MdiParent = this;
            purpleChild.Show();
        }

        private void yellowFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yellowChild = new ChildForm("Yellow Flowers", "yellowflowers");
            yellowChild.MdiParent = this;
            yellowChild.Show();
        }

        //exit app
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //set Cascade layout
        private void caaascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        //set Tilevertical layout
        private void tileHorizontaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //set Tilehorizontal layout
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
