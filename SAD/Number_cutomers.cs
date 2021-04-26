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
    public partial class Number_cutomers : Form
    {
        public Number_cutomers()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Order_food Of = new Order_food();
            Of.Show();

            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
