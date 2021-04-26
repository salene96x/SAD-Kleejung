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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //string message = "\tเงินทอน \n \t10.00";
            //MessageBox.Show(message);
            DialogResult dialog = MessageBox.Show("ต้องการยืนยันหรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DialogResult dialogOK = MessageBox.Show("10.00", "เงินทอน", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (dialogOK == DialogResult.OK)
                {
                    Application.OpenForms["Order_food"].Close();
                    this.Close();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
