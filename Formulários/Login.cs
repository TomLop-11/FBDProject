using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Volta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string server = "tcp:mednat.ieeta.pt\\SQLSERVER,8101"; // vai buscar o texto do server
            string user = textBoxUser.Text; // vai buscar o user
            string password = textBoxPass.Text; // vai buscar a password
            string dbname = "p2g8";
            if ( string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("ERROR: Server/Username/Password invalid!");
                return;
            }

            // variável global
            Global.ConnectionString = "Data Source = " + server + " ;" + "Initial Catalog = " + dbname + "; uid = " + user + ";" + "password = " + password + ";Encrypt=false";

            if (TestDBConnection(server, dbname, user, password))
            {
                this.Hide();
                PresentationTable menu = new PresentationTable();
                menu.FormClosed += (s, args) => this.Close();
                menu.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBoxServer.Text = string.Empty;
            textBoxUser.Text = string.Empty;
            textBoxPass.Text = string.Empty;
        }

        private bool TestDBConnection(string dbServer, string dbName, string userName, string userPass) // dbserver = server, dbname = nosso grupo, user = grupo, userpass = passworrd
        {
            SqlConnection CN = new SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName +
                                                       "; uid = " + userName + ";" + "password = " + userPass + ";Encrypt=false");

            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successful connection to database " + CN.Database + " on the " + CN.DataSource + " server", "Connection Test", MessageBoxButtons.OK);
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open connection to database due to the error \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return false;
            }

            if (CN.State == ConnectionState.Open)
                CN.Close();
            return true;
        }

        private string getTableContent(SqlConnection CN)
        {
            string str = "";

            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    int cnt = 1;
                    SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Hello", CN);
                    SqlDataReader reader;
                    reader = sqlcmd.ExecuteReader();

                    while (reader.Read())
                    {
                        str += cnt.ToString() + " - " + reader.GetInt32(reader.GetOrdinal("MsgID")) + ", ";
                        str += reader.GetString(reader.GetOrdinal("MsgSubject"));
                        str += "\n";
                        cnt += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open connection to database due to the error \r\n" + ex.Message, "Connection Error", MessageBoxButtons.OK);
            }

            if (CN.State == ConnectionState.Open)
                CN.Close();

            return str;
        }
    }
}
