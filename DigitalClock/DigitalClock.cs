using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("hh:mm");
            lblSnde.Text = time.ToString("ss");
            lblPm.Text = time.ToString("tt");
            lblDate.Text = time.ToString("dd/MM/yyyy");
            lblDay.Text = time.ToString("dddd");

        }
    }
}
