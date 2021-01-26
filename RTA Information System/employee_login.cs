using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RTA_Information_System
{
    public partial class employee_login : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\STUDY\University\Semester 06\Software Development 2\project\RTA Information System\RTA Information System\employee_login.accdb");
        public employee_login()
        {
            InitializeComponent();
            textBox1.Focus();
            textBox2.PasswordChar = '*';
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from table1 where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";

            OleDbDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                count++;
            }

            if (count == 1)
            {
                clear();
                employee_service frm2 = new employee_service();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

            con.Close();
        }
    }
}
