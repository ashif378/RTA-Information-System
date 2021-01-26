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
    public partial class add_emp : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\STUDY\University\Semester 06\Software Development 2\project\RTA Information System\RTA Information System\employee_login.accdb");

        public add_emp()
        {
            InitializeComponent();
        }

        private void add_emp_Load(object sender, EventArgs e)
        {

        }

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table1 values('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            clear();

            MessageBox.Show("Registration Complete!");
        }
    }
}
