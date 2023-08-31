using app.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.Data.OleDb;
using System.Data.SqlClient;
using ProiectIPLA.Clase;

namespace app
{
    public partial class FormAddNIR : Form
    {
        Utilizator u;
        NIR nir = new NIR();
        List<Produs> listaProduse = new List<Produs>();
        SqlConnection con =
      new SqlConnection("Server=tcp:myazureserver01.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=dbadmin;Password=Radumihai81!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public FormAddNIR(Utilizator util)
        {
            InitializeComponent();

            u = (Utilizator)util.Clone();

            con.Open();

            string query = "select denumire_furnizor from dbo.furnizor";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                cbFurnizor.Items.Add(sdr.GetString(0));
            }
            sdr.Close();

        }
        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            Produs nou = new Produs(tbDenProdus.Text, cbUm.Text, Int32.Parse(tbCant.Text), Double.Parse(tbPret.Text));
            nou.valoare = Double.Parse(tbPret.Text) * Int32.Parse(tbCant.Text) * 1.19;
            nou.valoareTVA = Double.Parse(tbPret.Text) * Int32.Parse(tbCant.Text) * 1.19 - (Double.Parse(tbPret.Text) * Int32.Parse(tbCant.Text));
            nou.valoareFaraTVA = Double.Parse(tbPret.Text) * Int32.Parse(tbCant.Text);

            tbDenProdus.Clear();
            cbUm.ResetText();
            tbCant.Clear();
            tbPret.Clear();

            listaProduse.Add(nou); 

            ListViewItem itm = new ListViewItem(nou.denumire.ToString());
                itm.SubItems.Add(nou.um.ToString());
                itm.SubItems.Add(nou.cantitate.ToString());
                itm.SubItems.Add(nou.pret.ToString());
                itm.SubItems.Add(nou.valoare.ToString());
                itm.SubItems.Add(nou.valoareTVA.ToString());
                itm.SubItems.Add(nou.valoareFaraTVA.ToString());
                lvNIRuri.Items.Add(itm);

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
        private void CreateWordDocument(object filename, object SaveAs, NIR nir, List<Produs> listaProduse)
        {
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
                foreach (Produs p in listaProduse)
                {
                    sbDenumire.Append(p.denumire).AppendLine();
                    int index = listaProduse.IndexOf(p) + 1;
                    sbNr.Append(index).AppendLine();
                    sbUm.Append(p.um).AppendLine();
                    sbCantitate.Append(p.cantitate).AppendLine();
                    sbPret.Append(p.pret).AppendLine();
                    double valoare = p.pret * p.cantitate;
                    sbValoare.Append(valoare).AppendLine();
                }

                String denumire = "first line" + Environment.NewLine + "second line";
            
                this.FindAndReplace(wordApp, "<data>", nir.data.ToShortDateString().ToString());
                this.FindAndReplace(wordApp, "<gestiune>", nir.gestiune.ToString());
                this.FindAndReplace(wordApp, "<idNir>", nir.id.ToString());
                this.FindAndReplace(wordApp, "<furnizor>", nir.furnizor.ToString());
                this.FindAndReplace(wordApp, "<tip>", nir.tip.ToString());
                this.FindAndReplace(wordApp, "<idNir2>", nir.id.ToString());
                this.FindAndReplace(wordApp, "<nr>", sbNr.ToString());
                this.FindAndReplace(wordApp, "<denumire>", sbDenumire.ToString());
                this.FindAndReplace(wordApp, "<um>", sbUm.ToString());
                this.FindAndReplace(wordApp, "<cantitateCf>", sbCantitate.ToString());
                this.FindAndReplace(wordApp, "<cantitate>", sbCantitate.ToString());
                this.FindAndReplace(wordApp, "<pret>", sbPret.ToString());
                this.FindAndReplace(wordApp, "<valoare>", sbValoare.ToString());
                this.FindAndReplace(wordApp, "<comisie>", nir.comisie.ToString());
                this.FindAndReplace(wordApp, "<comisie2>", nir.comisie.ToString());
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
            MessageBox.Show("NIR salvat!");
        }

        private void btnSaveNIR_Click(object sender, EventArgs e)
        {   

            nir = new NIR(Int32.Parse(tbId.Text), cbFurnizor.Text, cbTip.Text, DateTime.Parse(dtpData.Text), cbGestiune.Text, cbComisie.Text);
            
            double valoare = 0, valoareTVA = 0, valoareFaraTVA = 0;
            foreach (Produs p in listaProduse)
            {
                valoare = valoare + p.valoare;
                valoareTVA = valoareTVA + p.valoareTVA;
                valoareFaraTVA = valoareFaraTVA + p.valoareFaraTVA;
            }
            nir.valoare = valoare; nir.valoareTVA = valoareTVA; nir.valoareFaraTVA = valoareFaraTVA;
         
            con.Open();

            string queryInsertNIR = @"insert dbo.receptie (id_receptie, denumire_furnizor,tip_receptie,data,gestiune,comisie, valoare, valoare_tva, valoare_fara_tva) 
            values ('" + nir.id +"','"+ nir.furnizor
            + "', '" + nir.tip 
            + "', '" + nir.data.ToShortDateString() 
            + "', '" + nir.gestiune + "','" + nir.comisie + "','"
            + nir.valoare + "','" + nir.valoareTVA + "','" + nir.valoareFaraTVA + "')";

            SqlCommand commandInsertNIR = new SqlCommand(queryInsertNIR, con);
            commandInsertNIR.ExecuteNonQuery();

            foreach (Produs p in listaProduse)
            {
                string queryInsertProdusStoc = @"insert dbo.produs_stoc (denumire_produs,um,cantitate,pret,valoare,valoare_tva,valoare_fara_tva)
            values ('" + p.denumire + "', '" + p.um + "', '" + p.cantitate + "', '" + p.pret + "', '"
      + p.valoare + "','" + p.valoareTVA + "','" + p.valoareFaraTVA + "')";

                string queryInsertProdusReceptie = @"insert dbo.produs_receptie (id_receptie, denumire_produs,um,cantitate,pret,valoare,valoare_tva,valoare_fara_tva) 
            values ('" + nir.id + "', '" + p.denumire + "', '" + p.um + "', '" + p.cantitate + "', '" + p.pret + "', '"
                + p.valoare + "','" + p.valoareTVA + "','" + p.valoareFaraTVA + "')";

                SqlCommand commandInsertProdusStoc = new SqlCommand(queryInsertProdusStoc, con);
                commandInsertProdusStoc.ExecuteNonQuery();
               
                SqlCommand commandInsertProdusReceptie = new SqlCommand(queryInsertProdusReceptie, con);
                commandInsertProdusReceptie.ExecuteNonQuery();

            }

            con.Close();
            MessageBox.Show("Date adaugate cu succes!");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnStergeProdus_Click(object sender, EventArgs e)
        {
            if (lvNIRuri.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecteaza un produs!");
            }
            else
            {
               
                ListViewItem item = lvNIRuri.SelectedItems[0];
                Produs p = new Produs();
                p.denumire = item.Text;
                p.um= item.SubItems[1].Text;
                p.cantitate= Double.Parse(item.SubItems[2].Text);
                p.pret = Double.Parse(item.SubItems[3].Text);

                p.valoare = p.pret * p.cantitate * 1.19;
                p.valoareTVA = p.pret* p.cantitate* 1.19 - (p.pret * p.cantitate);
                p.valoareFaraTVA = p.pret* p.cantitate;

                listaProduse.Remove(p);
                lvNIRuri.SelectedItems[0].Remove();
               
            }
        }

        private void btnEditProdus_Click(object sender, EventArgs e)
        {
            if (lvNIRuri.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecteaza un produs!");
            }
            else
            {
                ListViewItem item = lvNIRuri.SelectedItems[0];
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

                listaProduse.Remove(p);
                lvNIRuri.SelectedItems[0].Remove();
            }
        }

        private void btnSalveazaNIRWord_Click(object sender, EventArgs e)
        {

            object filename = @"C:\Users\Alina\Desktop\Proiect IPLA\app\app\TemplateNIR.docx";
            object SaveAs = @"C:\Users\Alina\Desktop\Proiect IPLA\app\app\Receptie_" + nir.id.ToString() + ".docx";


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
                foreach (Produs p in listaProduse)
                {
                    sbDenumire.Append(p.denumire).AppendLine();
                    int index = listaProduse.IndexOf(p) + 1;
                    sbNr.Append(index).AppendLine();
                    sbUm.Append(p.um).AppendLine();
                    sbCantitate.Append(p.cantitate).AppendLine();
                    sbPret.Append(p.pret).AppendLine();
                    double valoare = p.pret * p.cantitate;
                    sbValoare.Append(valoare).AppendLine();
                }

                String denumire = "first line" + Environment.NewLine + "second line";

                this.FindAndReplace(wordApp, "<data>", nir.data.ToShortDateString().ToString());
                this.FindAndReplace(wordApp, "<gestiune>", nir.gestiune.ToString());
                this.FindAndReplace(wordApp, "<idNir>", nir.id.ToString());
                this.FindAndReplace(wordApp, "<furnizor>", nir.furnizor.ToString());
                this.FindAndReplace(wordApp, "<tip>", nir.tip.ToString());
                this.FindAndReplace(wordApp, "<idNir2>", nir.id.ToString());
                this.FindAndReplace(wordApp, "<nr>", sbNr.ToString());
                this.FindAndReplace(wordApp, "<denumire>", sbDenumire.ToString());
                this.FindAndReplace(wordApp, "<um>", sbUm.ToString());
                this.FindAndReplace(wordApp, "<cantitateCf>", sbCantitate.ToString());
                this.FindAndReplace(wordApp, "<cantitate>", sbCantitate.ToString());
                this.FindAndReplace(wordApp, "<pret>", sbPret.ToString());
                this.FindAndReplace(wordApp, "<valoare>", sbValoare.ToString());
                this.FindAndReplace(wordApp, "<comisie>", nir.comisie.ToString());
                this.FindAndReplace(wordApp, "<comisie2>", nir.comisie.ToString());
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
            MessageBox.Show("NIR salvat!");

            System.Diagnostics.Process.Start(SaveAs.ToString());


        }
    }
}
