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
    public partial class FormDash : Form
    {
       // Color color = Color.FromArgb(35,35,35);
        Utilizator u
              = new Utilizator("admin", "admin", "EUROPLAST S.R.L.", "RO23457653", "J24/2673/1994",
                  "Str. Campului 17A", "Dudu", "Ilfov", "Romania", "RO4900781B31007593840000"
                  , "BRD", "Ciopec Alina-Mihaela", "");

       // SqlConnection con =
       //new SqlConnection("Server=tcp:myazureserver01.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=dbadmin;Password=Radumihai81!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public FormDash()
        {
            InitializeComponent();

            //openChildForm(new FormReceptii(u));
          //  openChildForm(new FormRaport(u));

            //lblEmail.Text =u.username;
            //lblFirma.Text = u.denumire_firma;
            //lblPersoana.Text = u.persoana_contact;

            //string query = "select * from dbo.date_autentificare where username='admin'";
            //con.Open();
            //SqlCommand command = new SqlCommand(query, con);
            //SqlDataReader r = command.ExecuteReader();
            //if (r.Read())
            //{   
            //lblEmail.Text = r[0].ToString();
            //lblFirma.Text = r[2].ToString();
            //lblPersoana.Text = r[11].ToString();
            //}
            //r.Close();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void lblClose_Click(object sender, EventArgs e)
        {
           // Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          //  WindowState = FormWindowState.Minimized;
        }

        private void lblReceptii_Click(object sender, EventArgs e)
        {
           // openChildForm(new FormReceptii(u));
        }

        private void lblEmiteri_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormEmiteri(u));
        }

        private void lblStoc_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormStocProduse(u));
        }

        private void pnlLogout_Paint(object sender, PaintEventArgs e)
        {
           // Application.Exit();
        }

        private void pnlDashboard_Click(object sender, EventArgs e)
        {
          //  openChildForm(new FormRaport(u));
            //pnlDashboard.BackColor = Color.Gray;

            //pnlReceptii.BackColor = color;
        }
    }
}
