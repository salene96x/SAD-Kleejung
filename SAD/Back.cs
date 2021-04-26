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
    public partial class Back : UserControl
    {
        public Back()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item2 item = new Item2();
            item.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }
}
