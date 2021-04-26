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
    public partial class Manage_Table : Form
    {
        public Manage_Table()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zone11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zone21.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zone31.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zone41.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
