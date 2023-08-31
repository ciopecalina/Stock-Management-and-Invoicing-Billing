using app.Clase;
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
    public partial class FormEmiteri : Form
    {
        Utilizator u;
        SqlConnection con =
        new SqlConnection("Server=tcp:myazureserver01.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=dbadmin;Password=Radumihai81!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        List<Produs> listaProduseE = new List<Produs>();

        public FormEmiteri(Utilizator util)
        {
            InitializeComponent();

            u = (Utilizator)util.Clone();
            double valTotala = 0, valTVA = 0, valFaraTVA = 0;

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.emitere", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvFacturi.DataSource = dt;
            con.Close();

            lblNrFacturi.Text = dgvFacturi.RowCount.ToString();

            foreach (DataGridViewRow row in dgvFacturi.Rows)
            {
                valTotala += Double.Parse(row.Cells[4].Value.ToString());
                valTVA += Double.Parse(row.Cells[5].Value.ToString());
                valFaraTVA += Double.Parse(row.Cells[6].Value.ToString());
            }
            lbValoareTotala.Text = valTotala.ToString();
            lbValTVA.Text = valTVA.ToString();
            lbValFaraTVA.Text = valFaraTVA.ToString();

        }

        private void btnAddFactura_Click(object sender, EventArgs e)
        {
            FormAddFactura formAddFactura = new FormAddFactura(u);
            formAddFactura.Show();
        }

        private void btnStergereFactura_Click(object sender, EventArgs e)
        {
            if (dgvFacturi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecteaza o emitere!");
            }
            else
            {
                int index = dgvFacturi.SelectedRows[0].Index;
                con.Open();

                //update la produs_stoc
                string queryProdus = "select * from dbo.produs_emitere where serie='" + dgvFacturi.SelectedRows[0].Cells[0].Value.ToString() + "' and nr='" + dgvFacturi.SelectedRows[0].Cells[1].Value.ToString() + "'";

                SqlCommand commProdus = new SqlCommand(queryProdus, con);
                SqlDataReader dataReader = commProdus.ExecuteReader();
                while (dataReader.Read())
                {
                    Produs p = new Produs(dataReader.GetValue(2).ToString(), Double.Parse(dataReader.GetValue(4).ToString()));
                    listaProduseE.Add(p);
                    //MessageBox.Show(p.denumire+" ");
                }
                dataReader.Close();

                foreach (Produs p in listaProduseE)
                {
                    string queryUpdateCantitate = "update dbo.produs_stoc set "
                        + "cantitate=cantitate+" + p.cantitate + " "
                        + "where denumire_produs='" + p.denumire + "';";
                    SqlCommand commUpdateCantitate = new SqlCommand(queryUpdateCantitate, con);
                    commUpdateCantitate.ExecuteNonQuery();
                }
                foreach (Produs p in listaProduseE)
                {
                    string queryUpdateValoare = "update dbo.produs_stoc set "
                        + "valoare=pret*cantitate*1.19, "
                        + "valoare_tva=pret*cantitate*1.19-(pret*cantitate), "
                        + "valoare_fara_tva=pret*cantitate "
                        + "where denumire_produs='" + p.denumire + "';";

                    SqlCommand commUpdateValoare = new SqlCommand(queryUpdateValoare, con);
                    commUpdateValoare.ExecuteNonQuery();
                }

                //sterg prod_emitere produsele
                string queryStergereProduse = "DELETE FROM dbo.produs_emitere WHERE serie='" + dgvFacturi.SelectedRows[0].Cells[0].Value.ToString() + "' and nr='" + dgvFacturi.SelectedRows[0].Cells[1].Value.ToString() + "'";
                SqlCommand commStergereProduse = new SqlCommand(queryStergereProduse, con);
                commStergereProduse.ExecuteNonQuery();
                //sterg emitere
                string queryStergereEmitere = "DELETE FROM dbo.emitere WHERE serie='" + dgvFacturi.SelectedRows[0].Cells[0].Value.ToString() + "' and nr='" + dgvFacturi.SelectedRows[0].Cells[1].Value.ToString() + "'";
                SqlCommand commStergereEmitere = new SqlCommand(queryStergereEmitere, con);
                commStergereEmitere.ExecuteNonQuery();

                con.Close();
                dgvFacturi.Rows.RemoveAt(index);
                lblNrFacturi.Text = dgvFacturi.RowCount.ToString();
                MessageBox.Show("Factura stearsa cu succes!");

            }
        }

       
    }
}
