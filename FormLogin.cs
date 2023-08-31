using ProiectIPLA.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class FormLogin : Form
    {
        SqlConnection con =
          new SqlConnection("Server=tcp:myazureserver01.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=dbadmin;Password=Radumihai81!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        Utilizator u;

        public FormLogin()
        {  
            InitializeComponent();
            tbUsername.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, parola;
            username = tbUsername.Text;
            parola = tbParola.Text;
            try
            {
                string query = "select * from dbo.date_autentificare where username='admin' and parola='admin'";
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader r = command.ExecuteReader();
                if (r != null)
                {
                    u = new Utilizator(
                    r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(),
                    r[5].ToString(), r[6].ToString(), r[7].ToString(), r[8].ToString(), r[9].ToString(),
                    r[10].ToString(), r[11].ToString(), r[12].ToString());
                    MessageBox.Show(r[0].ToString());
                    r.Close();

                    FormDash formDash = new FormDash();
                    formDash.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Date incorecte!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    tbUsername.Clear();
                    tbParola.Clear();
                    tbUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Eroare!");
            }
            finally {
                con.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbParola.Clear();
            tbUsername.Focus();
        }
    }
}
