using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class tabControlForm : Form
    {
        public tabControlForm()
        {
            InitializeComponent();
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Black;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Red;
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor= Color.Green;
        }
        private void radioButtonPoint12_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 12);
        }

        private void radioButtonPoint16_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 16);
        }

        private void radioButtonPoint20_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 20);
        }

        private void radioButtonHello_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Hello!";
        }

        private void radioButtonGoodBye_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Goodbye!";
        }
    }
}
