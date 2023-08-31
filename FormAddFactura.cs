using app.Clase;
using ProiectIPLA.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace app
{
    public partial class FormAddFactura : Form
    {
        Utilizator u;
        Factura factura = new Factura();
        List<Produs> listaProduse = new List<Produs>();
        List<Produs> listaProduseLV = new List<Produs>();
        List<Client> listaClienti = new List<Client>();
        Furnizor f;
        SqlConnection con =
       new SqlConnection("Server=tcp:myazureserver01.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=dbadmin;Password=Radumihai81!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public FormAddFactura(Utilizator util)
        {
            InitializeComponent();

            u = (Utilizator)util.Clone();
            con.Open();

            string query = "select * from dbo.produs_stoc";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader sdr = command.ExecuteReader();
            AutoCompleteStringCollection autotex = new AutoCompleteStringCollection();
            while (sdr.Read())
            {
                autotex.Add(sdr.GetString(0));
                Produs p = new Produs(sdr.GetValue(0).ToString(), sdr.GetValue(1).ToString(), Double.Parse(sdr.GetValue(2).ToString()), Double.Parse(sdr.GetValue(3).ToString()));
                listaProduse.Add(p);
            }
            tbDenProdus.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbDenProdus.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbDenProdus.AutoCompleteCustomSource = autotex;

            sdr.Close();

            string query2 = "select * from dbo.client";
            SqlCommand command2 = new SqlCommand(query2, con);
            SqlDataReader sdr2 = command2.ExecuteReader();
            AutoCompleteStringCollection autotex2 = new AutoCompleteStringCollection();
            while (sdr2.Read())
            {
                autotex2.Add(sdr2.GetString(0));
                Client c = new Client(sdr2.GetString(0), sdr2.GetString(1), sdr2.GetString(2), sdr2.GetString(3), sdr2.GetString(4), sdr2.GetString(5), sdr2.GetString(6));
                listaClienti.Add(c);
            }
            sdr2.Close();
            tbDenClient.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbDenClient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbDenClient.AutoCompleteCustomSource = autotex2;

            string query3 = "select * from dbo.date_autentificare where username='admin'";

            SqlCommand command3 = new SqlCommand(query3, con);
            SqlDataReader r = command3.ExecuteReader();
            if (r.Read())
            {
                f = new Furnizor(r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString(), r[6].ToString(), r[7].ToString(), r[8].ToString(), r[9].ToString(), r[10].ToString());
            }
            r.Close();

            //MessageBox.Show(f.denumire_furnizor);
            con.Close();
            
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)

        {   Produs nou = new Produs(tbDenProdus.Text, cbUm.Text, Int32.Parse(tbCant.Text), Double.Parse(tbPret.Text));
            nou.valoare = Double.Parse(tbPret.Text) * Int32.Parse(tbCant.Text) * 1.19;
            nou.valoareTVA = Double.Parse(tbPret.Text) * Int32.Parse(tbCant.Text) * 1.19 - (Double.Parse(tbPret.Text) * Int32.Parse(tbCant.Text));
            nou.valoareFaraTVA = Double.Parse(tbPret.Text) * Int32.Parse(tbCant.Text);

            tbDenProdus.Text = "";
            cbUm.ResetText();
            tbCant.Clear();
            tbPret.Clear();

            listaProduseLV.Add(nou);

            ListViewItem itm = new ListViewItem(nou.denumire.ToString());
            itm.SubItems.Add(nou.um.ToString());
            itm.SubItems.Add(nou.cantitate.ToString());
            itm.SubItems.Add(nou.pret.ToString());
            itm.SubItems.Add(nou.valoare.ToString());
            itm.SubItems.Add(nou.valoareTVA.ToString());
            itm.SubItems.Add(nou.valoareFaraTVA.ToString());
            lvFacturi.Items.Add(itm);

        }

        private void tbDenProdus_TextChanged(object sender, EventArgs e)
        {
            Produs selectat = listaProduse.FirstOrDefault(item => item.denumire == tbDenProdus.Text);
            if (selectat != null)
            {
                lblStoc.Text = selectat.cantitate.ToString();
                lblPret.Text = selectat.pret.ToString();
                cbUm.Text = selectat.um.ToString();
            }
            else {
                lblStoc.Text ="0";
                lblPret.Text ="0";
                cbUm.Text ="";
            }
        }

        private void tbDenClient_TextChanged(object sender, EventArgs e)
        {
            Client selectat = listaClienti.FirstOrDefault(item => item.denumire_client == tbDenClient.Text);
            if (selectat != null)
            {
                lblAdresa.Text = selectat.adresa;
                lblCif.Text = selectat.cif_client;
                lblRegCom.Text = selectat.reg_com;
                lblLocalitate.Text = selectat.localitate;
                lblJudet.Text = selectat.judet;
                lblTara.Text = selectat.tara;
                lblDenumireFirma.Text = selectat.denumire_client;
            }
            else
            {
                lblAdresa.Text = "";
                lblCif.Text = "";
                lblRegCom.Text = "";
                lblLocalitate.Text = "";
                lblJudet.Text = "";
                lblTara.Text = "";
                lblDenumireFirma.Text = "";
            }
        }

        private void btnStergeProdus_Click(object sender, EventArgs e)
        {
            if (lvFacturi.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecteaza un produs!");
            }
            else
            {

                ListViewItem item = lvFacturi.SelectedItems[0];
                Produs p = new Produs();
                p.denumire = item.Text;
                p.um = item.SubItems[1].Text;
                p.cantitate = Double.Parse(item.SubItems[2].Text);
                p.pret = Double.Parse(item.SubItems[3].Text);

                p.valoare = p.pret * p.cantitate * 1.19;
                p.valoareTVA = p.pret * p.cantitate * 1.19 - (p.pret * p.cantitate);
                p.valoareFaraTVA = p.pret * p.cantitate;

                listaProduseLV.Remove(p);
                lvFacturi.SelectedItems[0].Remove();

            }
        }

        private void btnEditProdus_Click(object sender, EventArgs e)
        {
            if (lvFacturi.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecteaza un produs!");
            }
            else
            {
                ListViewItem item = lvFacturi.SelectedItems[0];
                Produs p = new Produs();
                p.denumire = item.Text;
                p.um = item.SubItems[1].Text;
                p.cantitate = Double.Parse(item.SubItems[2].Text);
                p.pret = Double.Parse(item.SubItems[3].Text);
                p.valoare = p.pret * p.cantitate * 1.19;
                p.valoareTVA = p.pret * p.cantitate * 1.19 - (p.pret * p.cantitate);
                p.valoareFaraTVA = p.pret * p.cantitate;

                tbDenProdus.Text = p.denumire;
                cbUm.Text = p.um;
                tbCant.Text = p.cantitate.ToString();
                tbPret.Text = p.pret.ToString();

                listaProduseLV.Remove(p);
                lvFacturi.SelectedItems[0].Remove();
            }
        }

        private void btnSaveFactura_Click(object sender, EventArgs e)
        {
                factura= new Factura(tbSerie.Text, tbNr.Text, tbDenClient.Text, DateTime.Parse(dtpData.Text),tbEmitent.Text,tbCNP.Text,
                tbAviz.Text, tbDelegat.Text, tbBuletin.Text,tbAuto.Text, rtbMentiuni.Text);

           double valoare = 0, valoareTVA = 0, valoareFaraTVA = 0;
            foreach (Produs p in listaProduseLV)
            {
                valoare = valoare + p.valoare;
                valoareTVA = valoareTVA + p.valoareTVA;
                valoareFaraTVA = valoareFaraTVA + p.valoareFaraTVA;
            }

            factura.valoare = valoare; factura.valoareTVA = valoareTVA; factura.valoareFaraTVA = valoareFaraTVA;

            con.Open();

            string queryInsertFactura = @"insert dbo.emitere (serie, nr, denumire_client, data, valoare, valoare_tva, valoare_fara_tva, nume_emitent, cnp_emitent, aviz, delegat, buletin, vehicul, mentiuni)
            values ('" + factura.serie + "','" + factura.nr+"','" +factura.denumire_client
            + "', '" + factura.data.ToShortDateString() + "','"
            + factura.valoare + "','" + factura.valoareTVA + "','" + factura.valoareFaraTVA
            + "', '" + factura.nume_emitent + "','" + factura.CNP_emitent + "','" + factura.aviz + "','" + factura.delegat + "','" + factura.buletin + "','"
            + factura.vehicul + "','" + factura.mentiuni + "')";

            SqlCommand commandInsertFactura = new SqlCommand(queryInsertFactura, con);
            commandInsertFactura.ExecuteNonQuery();

            foreach (Produs p in listaProduseLV)
            {
                string queryUpdateCantitate = "update dbo.produs_stoc set "
                    + "cantitate=cantitate-" + p.cantitate + " "
                    + "where denumire_produs='" + p.denumire + "';";
                SqlCommand commUpdateCantitate = new SqlCommand(queryUpdateCantitate, con);
                commUpdateCantitate.ExecuteNonQuery();
            }
            
            foreach (Produs p in listaProduseLV)
            {
                string queryUpdateValoare = "update dbo.produs_stoc set "
                    + "valoare=pret*cantitate*1.19, "
                    + "valoare_tva=pret*cantitate*1.19-(pret*cantitate), "
                    + "valoare_fara_tva=pret*cantitate "
                    + "where denumire_produs='" + p.denumire + "';";

                SqlCommand commUpdateValoare = new SqlCommand(queryUpdateValoare, con);
                commUpdateValoare.ExecuteNonQuery();
            }
            
            foreach (Produs p in listaProduseLV)
            {
            string queryInsertProdus = @"insert dbo.produs_emitere (serie, nr, denumire_produs, um, cantitate, pret, valoare, valoare_tva, valoare_fara_tva)
            values ('" + factura.serie + "','" + factura.nr + "','" + p.denumire + "','"
            + p.um + "','" + p.cantitate + "','" + p.pret + "','"
            + p.valoare + "','" + p.valoareTVA + "','" + p.valoareFaraTVA+ "')";
               
             SqlCommand commInsertProdus = new SqlCommand(queryInsertProdus, con);
             commInsertProdus.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Date inregistrate cu succes!");
        }

        private void btnSalveazaFactWord_Click(object sender, EventArgs e)
        {
            object filename = @"C:\Users\Alina\Desktop\Proiect IPLA\app\app\TemplateFactura.docx";
            object SaveAs = @"C:\Users\Alina\Desktop\Proiect IPLA\app\app\Factura_"+factura.serie.ToString()+"-"+factura.nr.ToString()+ ".docx";


            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                var sbDenumire = new StringBuilder(); sbDenumire.Append(" ");
                var sbNr = new StringBuilder(); sbNr.Append(" ");
                var sbUm = new StringBuilder(); sbUm.Append(" ");
                var sbCantitate = new StringBuilder(); sbCantitate.Append(" ");
                var sbPret = new StringBuilder(); sbPret.Append(" ");
                var sbValoare = new StringBuilder(); sbValoare.Append(" ");
                var sbValoareTVA = new StringBuilder(); sbValoareTVA.Append(" ");
                foreach (Produs p in listaProduseLV)
                {
                    sbDenumire.Append(p.denumire).AppendLine();
                    int index = listaProduseLV.IndexOf(p) + 1;
                    sbNr.Append(index).AppendLine();
                    sbUm.Append(p.um).AppendLine();
                    sbCantitate.Append(p.cantitate).AppendLine();
                    sbPret.Append(p.pret).AppendLine();
                    sbValoare.Append(p.valoare).AppendLine();
                    sbValoareTVA.Append(p.valoareTVA).AppendLine();
                }

                //fact
                this.FindAndReplace(wordApp, "<d>", factura.data.ToShortDateString());
                this.FindAndReplace(wordApp, "<s>", factura.serie);
                this.FindAndReplace(wordApp, "<n>", factura.nr);
                this.FindAndReplace(wordApp, "<a>", factura.aviz);

                //furnizor
                this.FindAndReplace(wordApp, "<denumire_f>",f.denumire_furnizor);
                this.FindAndReplace(wordApp, "<reg_com_f>", f.reg_com);
                this.FindAndReplace(wordApp, "<cif_f>", f.cif_furnizor);
                this.FindAndReplace(wordApp, "<adresa_f>", f.adresa);
                this.FindAndReplace(wordApp, "<localitate_f>",f.localitate);
                this.FindAndReplace(wordApp, "<judet_f>", f.judet);
                this.FindAndReplace(wordApp, "<iban>", f.iban);
                this.FindAndReplace(wordApp, "<banca>", f.banca);
                //client
                this.FindAndReplace(wordApp, "<denumire_c>",lblDenumireFirma.Text);
                this.FindAndReplace(wordApp, "<reg_com_c>", lblRegCom.Text);
                this.FindAndReplace(wordApp, "<cif_c>",lblCif.Text);
                this.FindAndReplace(wordApp, "<adresa_c>",lblAdresa.Text);
                this.FindAndReplace(wordApp, "<localitate_c>", lblLocalitate.Text);
                this.FindAndReplace(wordApp, "<judet_c>", lblJudet.Text);
                //prod
                this.FindAndReplace(wordApp, "<nr_p>", sbNr.ToString());
                this.FindAndReplace(wordApp, "<denumire_p>", sbDenumire.ToString());
                this.FindAndReplace(wordApp, "<um>", sbUm.ToString());
                this.FindAndReplace(wordApp, "<cant>", sbCantitate.ToString());
                this.FindAndReplace(wordApp, "<pret>", sbPret.ToString());
                this.FindAndReplace(wordApp, "<p_val>", sbValoare.ToString());
                this.FindAndReplace(wordApp, "<p_valTVA>", sbValoareTVA.ToString());
                //

                this.FindAndReplace(wordApp, "<mentiuni>", factura.mentiuni);
                this.FindAndReplace(wordApp, "<nume_emitent>", factura.nume_emitent);
                this.FindAndReplace(wordApp, "<cnp_emitent>", factura.CNP_emitent);
                this.FindAndReplace(wordApp, "<delegat>", factura.delegat);
                this.FindAndReplace(wordApp, "<buletin>", factura.buletin);
                this.FindAndReplace(wordApp, "<vehicul>", factura.vehicul);

                this.FindAndReplace(wordApp, "<f_valfTVA>", factura.valoareFaraTVA);
                this.FindAndReplace(wordApp, "<f_valTVA>", factura.valoareTVA);
                this.FindAndReplace(wordApp, "<f_val>", factura.valoare);

            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Document salvat!");

            System.Diagnostics.Process.Start(SaveAs.ToString());

        }

        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

       
    }
}
