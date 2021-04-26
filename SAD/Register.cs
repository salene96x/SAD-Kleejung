using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SAD
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Form1.GetConnection();
            MySqlDataReader reader;
            connection.Open();
            MySqlCommand check_User_Name = new MySqlCommand("SELECT login_id FROM login_data WHERE login_id = @user;", connection);
            check_User_Name.Parameters.Clear();
            check_User_Name.Parameters.AddWithValue("user", textBox1.Text);
            reader = check_User_Name.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("ชื่อผู้ใช้นี้มีการใช้งานแล้ว");
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้นี้ยังไม่มีการใช้งาน");
            }
            connection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertData(textBox1.Text, textBox2.Text, textBox3.Text);
        }
        void InsertData(string id, string pwd, string conPwd)
        {
            MySqlConnection conn = Form1.GetConnection();
            conn.Open();
            if (!(pwd == conPwd))
            {
                MessageBox.Show("พาสเวิร์ดไม่ตรงกัน กรุณากรอกใหม่");
            }
            else
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO login_data VALUES (@id, @pwd)", conn);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("pwd", pwd);
                command.ExecuteNonQuery();
                MessageBox.Show("เพิ่มข้อมูลเสร็จสิ้น");
            }
            conn.Close();
        }
    }
}
