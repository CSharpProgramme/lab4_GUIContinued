using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    //form lets user select a drop-off date using a DateTimePicker
    //and displays an estimated delivery date
    public partial class DateTimePickerForm : Form
    {
        public DateTimePickerForm()
        {
            InitializeComponent();
        }

        private void dropOffDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dropOffDate = dropOffDatePicker.Value;

            //add extra time when items are dropped off sunday
            if (dropOffDate.DayOfWeek == DayOfWeek.Friday || dropOffDate.DayOfWeek == DayOfWeek.Saturday || dropOffDate.DayOfWeek == DayOfWeek.Sunday)
            {
                //estimate three days for delivery
                outputLabel.Text = dropOffDate.AddDays(3).ToLongDateString();
            }
            else
            { 
                //otherwise estimate only two days for delivery
                outputLabel.Text = dropOffDate.AddDays(2).ToLongDateString();
            }
        }

        private void DateTimePickerForm_Load(object sender, EventArgs e)
        {
            //user cannot select days before today
            dropOffDatePicker.MinDate = DateTime.Today;

            //user can only select days up to one year in the future
            dropOffDatePicker.MaxDate = DateTime.Today.AddYears(1);
        }
    }
}
