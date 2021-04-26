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
    public partial class Order_food : Form
    {
        public Order_food()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Order_food_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "999")
            {
                Add_food addfood = new Add_food();
                addfood.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Table managetable = new Manage_Table();
            managetable.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number_cutomers number_cus = new Number_cutomers();
            number_cus.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.button3.Text = dateTime.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = DateTime.Now.ToLongDateString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Improve impro = new Improve();
            impro.Show();
        }
    }
}
