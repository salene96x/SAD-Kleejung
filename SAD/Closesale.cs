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
    public partial class Closesale : Form
    {
        public Closesale()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cash_drawer cash = new Cash_drawer();
            cash.Show();
        }
    }
}
