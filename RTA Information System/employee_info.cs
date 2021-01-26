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
    public partial class emp_pass : Form
    { 
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\STUDY\University\Semester 06\Software Development 2\project\RTA Information System\RTA Information System\employee_login.accdb");

    
        public emp_pass()
        {
            InitializeComponent();
        }

        private void emp_pass_Load(object sender, EventArgs e)
        {
        con.Open();

        OleDbCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select Full_Name, username, password from Table1";
        cmd.ExecuteNonQuery();

        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        da.Fill(dt);
        dataGridView1.DataSource = dt;


        con.Close();
    }
    }
}
