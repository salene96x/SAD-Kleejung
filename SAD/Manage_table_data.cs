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
    public partial class Manage_table_data : Form
    {
        public Manage_table_data()
        {
            InitializeComponent();
        }

        private void Manage_table_data_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            book1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            history history = new history();
            history.Show();
        }
    }
}
