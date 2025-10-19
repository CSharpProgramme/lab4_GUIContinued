﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Box
{
    public partial class comboBox : Form
    {
        public comboBox()
        {
            InitializeComponent();
        }

        private void imageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //create graphics object, pen, and SolidBrush
            using (Graphics myGraphics = base.CreateGraphics())

            //create Pen using color DarkRed
            using (Pen myPen = new Pen(Color.DarkRed))

            //create SolidBrush using color DarkRed
            using (SolidBrush mySolidBrush = new SolidBrush(Color.DarkRed))
            {
                //clear drawing area, setting it to color white
                myGraphics.Clear(Color.White);

                //find index, draw proper shape
                switch (imageComboBox.SelectedIndex)
                {
                    case 0://case circle is selected
                        myGraphics.DrawEllipse(myPen, 50, 50, 150, 150);
                        break;
                    case 1://case rectangle is selected
                        myGraphics.DrawRectangle(myPen, 50, 50, 150, 150);
                        break;
                    case 2://case ellipse is selected
                        myGraphics.DrawEllipse(myPen, 50, 85, 150, 115);
                        break;
                    case 3://case pie is selected
                        myGraphics.DrawPie(myPen, 50, 50, 150, 150, 0, 45);
                        break;
                    case 4://case filled circle is selected
                        myGraphics.FillEllipse(mySolidBrush, 50, 50, 150, 150);
                        break;
                    case 5://case filled rectangle is selected
                        myGraphics.FillRectangle(mySolidBrush, 50, 50, 150, 150);
                        break;
                    case 6://case filled ellipse is selected
                        myGraphics.FillEllipse(mySolidBrush, 50, 85, 150, 115);
                        break;
                    case 7://case filled pie is selected
                        myGraphics.FillPie(mySolidBrush, 50, 50, 150, 150, 0, 45);
                        break;
                }
            }
        }
    }
}
