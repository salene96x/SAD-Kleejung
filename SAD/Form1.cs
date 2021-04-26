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
using System.Diagnostics;

namespace SAD
{
    public partial class Form1 : Form
    {
        private static string conStr = "datasource=127.0.0.1;port=3306;username=root;password=;database=srijun_db;";
        private static MySqlConnection conn = new MySqlConnection(conStr);
        private static MySqlCommand command;
        private static MySqlDataReader reader;
        private List<string> pwdArr = new List<string>();
        private List<string> usernameArr = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkID(textBox1.Text, textBox2.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Register regis = new Register();
            regis.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public static MySqlConnection GetConnection()
        {
            return conn;
        }
        void checkID (string username, string pwd)
        {
            conn.Open();
            command = new MySqlCommand("SELECT * FROM login_data WHERE login_id = @id;", conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("id", username);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(0) == username && reader.GetString(1) == pwd)
                    {
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                        MessageBox.Show("Successfully login");
                    }
                    else
                    {
                        MessageBox.Show("ล็อคอินไม่สำเร็จ กรุณาตรวจสอบพาสเวิร์ดและชื่อผู้ใช้");
                    }
                }
            }
            conn.Close();
        }
    }
}