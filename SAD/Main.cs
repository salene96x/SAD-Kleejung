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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "เปิดกะการขาย")
            {
                button3.Text = "ปิดกะการขาย";
                button3.BackColor = Color.Red;
                Open_sales os = new Open_sales();
                os.Show();

            }
            else if (button3.Text == "ปิดกะการขาย")
            {
                DialogResult dialog = MessageBox.Show("ต้องการปิดการขายหรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Closesale closesale = new Closesale();
                    closesale.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            front1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            back1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
