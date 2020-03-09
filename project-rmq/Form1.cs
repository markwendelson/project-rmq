using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_rmq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txtRMQ_Host.Text == "" ||
                txtRMQ_Username.Text == "" ||
                txtRMQ_Password.Text == "" ||
                cboDatabaseServer.Text == "" ||
                txtDB_Host.Text == "" ||
                txtDB_Port.Text == "" ||
                txtDB_Username.Text == "" ||
                txtDB_Password.Text == "" ||
                txtDB_Name.Text == "")
            {
                MessageBox.Show("Fill all fields.","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //fill database information
            var db = new DBConnection();
            db.db_server = cboDatabaseServer.Text;
            db.db_host = txtDB_Host.Text;
            db.db_port = int.Parse(txtDB_Port.Text.ToString());
            db.db_user = txtDB_Username.Text;
            db.db_password = txtDB_Password.Text;
            db.db_name = txtDB_Name.Text;

            if(db.db_server == "SQL Server")
            {
                SqlConnection cn = db.SqlConnect();
                cn.Open();
                Console.WriteLine(cn.State);
            }
            else if(db.db_server == "MySQL Server")
            {
                MySqlConnection cn = db.MySqlConnect();
                cn.Open();
                Console.WriteLine(cn.State);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/RmqClient.exe";
            Process p = new Process();
            p.StartInfo.FileName = path;

            p.Start();
        }
    }
}
