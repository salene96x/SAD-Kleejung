using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number_cutomers num_ctm = new Number_cutomers();
            num_ctm.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            zone1_Main1.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            zone2_Main1.BringToFront();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            zone3_Main1.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            zone4_Main1.BringToFront();
        }
    }
}
