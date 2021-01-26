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
    public partial class admin_login : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\STUDY\University\Semester 06\Software Development 2\project\RTA Information System\RTA Information System\admin_login.accdb");
        public admin_login()
        {
            InitializeComponent();
            textBox1.Focus();
            textBox2.PasswordChar = '*';
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
                admin_panel frm15 = new admin_panel();
                frm15.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

            con.Close();

           /*admin_panel frm15 = new admin_panel();
            frm15.Show();*/
        }
    }
}
