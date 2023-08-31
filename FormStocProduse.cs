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
    public partial class FormStocProduse : Form
    {
        Utilizator u;
        static SqlConnection con =
        new SqlConnection("Server=tcp:myazureserver01.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=dbadmin;Password=Radumihai81!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public FormStocProduse(Utilizator util)
        {
            InitializeComponent();

            u = (Utilizator)util.Clone();
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.produs_stoc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvProduse.DataSource = dt;
            con.Close();

            lblNrProduse2.Text = dgvProduse.RowCount.ToString();
            cbUM.SelectedItem = "Toate";
        }


        private void tbSearchProdus_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from dbo.produs_stoc where denumire_produs like '%" + tbSearchProdus.Text + "%'";

            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvProduse.DataSource = dt;
            con.Close();
            lblNrProduse2.Text = dgvProduse.RowCount.ToString();
        }

        private void btnAddFiltru_Click(object sender, EventArgs e)
        {
            dgvProduse.DataSource = null;
            this.dgvProduse.Rows.Clear();

            
            // string query = "select * from dbo.produs_stoc where um='" + cbUM.Text + "'";
            //string query = "select * from dbo.produs_stoc where pret between " + tbPretMin.Text + " and "+ tbPretMax.Text;
            //string query = "select * from dbo.produs_stoc where valoare between " + tbValMin.Text + " and " + tbValMax.Text;
            //string query1 = "select * from dbo.produs_stoc where cantitate between " + tbCantMin.Text + " and " + tbCantMax.Text;

            string query = "select * from dbo.produs_stoc where denumire_produs like '%" + tbSearchProdus.Text + "%'";
            if (!(tbPretMin.Text.Equals("")) && !(tbPretMax.Text.Equals("")))
            {
                query += " and pret between " + tbPretMin.Text + " and " + tbPretMax.Text;
            }
            if (!(tbValMin.Text.Equals("")) && !(tbValMax.Text.Equals("")))
            {
                query += " and valoare between " + tbValMin.Text + " and " + tbValMax.Text;
            }
            if (!(tbCantMin.Text.Equals("")) && !(tbCantMax.Text.Equals("")))
            {
                query += " and cantitate between " + tbCantMin.Text + " and " + tbCantMax.Text;
            }
            if (!(cbUM.Text.Equals("Toate")))
            {
                query += " and um='" + cbUM.Text + "'";
            }


            con.Open();
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvProduse.DataSource = dt;
            con.Close();

            lblNrProduse2.Text = dgvProduse.RowCount.ToString();
        }

        private void btnStergeFiltru_Click(object sender, EventArgs e)
        {
            dgvProduse.DataSource = null;
            dgvProduse.Rows.Clear();

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.produs_stoc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvProduse.DataSource = dt;
            con.Close();

            cbUM.SelectedItem = "Toate";
            tbSearchProdus.Text = "";
            tbCantMin.Text = ""; tbCantMax.Text = "";
            tbValMin.Text = ""; tbValMax.Text = "";
            tbPretMin.Text = ""; tbPretMax.Text = "";

            lblNrProduse2.Text = dgvProduse.RowCount.ToString();
        }

        private void tbPretProdus_TextChanged(object sender, EventArgs e)
        {
            if ((tbCantitateProdus.Text.Equals("")) || (tbPretProdus.Text.Equals("")))
            {
                tbValoareProdus.Text = "0";
                tbTVAProdus.Text = "0";
                tbFaraTVAProdus.Text = "0";
            }
            else
            {
                tbValoareProdus.Text = (Double.Parse(tbPretProdus.Text) * Int32.Parse(tbCantitateProdus.Text) * 1.19).ToString();
                tbTVAProdus.Text = (Double.Parse(tbPretProdus.Text) * Int32.Parse(tbCantitateProdus.Text) * 1.19 - (Double.Parse(tbPretProdus.Text) * Int32.Parse(tbCantitateProdus.Text))).ToString();
                tbFaraTVAProdus.Text = (Double.Parse(tbPretProdus.Text) * Int32.Parse(tbCantitateProdus.Text)).ToString();

            }
        }

        private void tbCantitateProdus_TextChanged(object sender, EventArgs e)
        {
            if ((tbCantitateProdus.Text.Equals(""))|| (tbPretProdus.Text.Equals("")))
            {
                tbValoareProdus.Text = "0";
                tbTVAProdus.Text = "0";
                tbFaraTVAProdus.Text = "0";
            }
            else
            {
                tbValoareProdus.Text = (Double.Parse(tbPretProdus.Text) * Int32.Parse(tbCantitateProdus.Text) * 1.19).ToString();
                tbTVAProdus.Text = (Double.Parse(tbPretProdus.Text) * Int32.Parse(tbCantitateProdus.Text) * 1.19 - (Double.Parse(tbPretProdus.Text) * Int32.Parse(tbCantitateProdus.Text))).ToString();
                tbFaraTVAProdus.Text = (Double.Parse(tbPretProdus.Text) * Int32.Parse(tbCantitateProdus.Text)).ToString();

            }
        }

        private void btnAddProdus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert dbo.produs_stoc (denumire_produs, um, cantitate, pret, valoare, valoare_tva, valoare_fara_tva)"
                +" values ('" + tbDenumireProdus.Text + "','" + cbUMProdus.SelectedItem
            + "', '" + tbCantitateProdus.Text
            + "', '" + tbPretProdus.Text
            + "', '" + tbValoareProdus.Text + "','" + tbTVAProdus.Text + "','" + tbFaraTVAProdus.Text + "')";

            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Date adaugate cu succes!");

            tbDenumireProdus.Text = "";
            cbUMProdus.SelectedItem = null;
            tbCantitateProdus.Text = "";
            tbPretProdus.Text = "";
            tbValoareProdus.Text = "";
            tbTVAProdus.Text = "";
            tbFaraTVAProdus.Text = "";

            dgvProduse.DataSource = null;
            dgvProduse.Rows.Clear();

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.produs_stoc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvProduse.DataSource = dt;
            con.Close();

            lblNrProduse2.Text = dgvProduse.RowCount.ToString();

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvProduse.SelectedRows.Count < 1)
            {

                MessageBox.Show("Selecteaza un produs!");
            }
            else
            {
                int index = dgvProduse.SelectedRows[0].Index;
                con.Open();
                string query = "DELETE FROM dbo.produs_stoc WHERE denumire_produs='" + dgvProduse.SelectedRows[0].Cells[0].Value + "'";
                SqlCommand comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();
                con.Close();
                dgvProduse.Rows.RemoveAt(index);
             
                MessageBox.Show("Produs sters cu succes!");

                tbDenumireProdus.Text = "";
                cbUMProdus.SelectedItem = null;
                tbCantitateProdus.Text = "";
                tbPretProdus.Text = "";
                tbValoareProdus.Text = "";
                tbTVAProdus.Text = "";
                tbFaraTVAProdus.Text = "";
                lblNrProduse2.Text = dgvProduse.RowCount.ToString();

            }
        }

        private void btnEditProdus_Click(object sender, EventArgs e)
        {
            if (dgvProduse.SelectedRows.Count < 1)
            {
                
                MessageBox.Show("Selecteaza un produs!");
            }
            else
            {
                int index = dgvProduse.SelectedRows[0].Index;

                tbDenumireProdus.Text = dgvProduse.SelectedRows[0].Cells[0].Value.ToString();
                cbUMProdus.SelectedItem = dgvProduse.SelectedRows[0].Cells[1].Value.ToString();
                tbCantitateProdus.Text = dgvProduse.SelectedRows[0].Cells[2].Value.ToString();
                tbPretProdus.Text = dgvProduse.SelectedRows[0].Cells[3].Value.ToString();
                tbValoareProdus.Text = dgvProduse.SelectedRows[0].Cells[4].Value.ToString();
                tbTVAProdus.Text = dgvProduse.SelectedRows[0].Cells[5].Value.ToString();
                tbFaraTVAProdus.Text = dgvProduse.SelectedRows[0].Cells[6].Value.ToString();


                con.Open();
                string query = "DELETE FROM dbo.produs_stoc WHERE denumire_produs='" + dgvProduse.SelectedRows[0].Cells[0].Value + "'";
                SqlCommand comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();
                con.Close();
                dgvProduse.Rows.RemoveAt(index);
                lblNrProduse2.Text = dgvProduse.RowCount.ToString();
                MessageBox.Show("Produs sters cu succes!");

                dgvProduse.Rows.RemoveAt(index);

            }
        }
    }
}
