using app.Clase;
using ProiectIPLA.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace app
{
    public partial class FormReceptii : Form
    {
        Utilizator u;
        List<NIR> listaNIR = new List<NIR>();
        List<Produs> listaProduse = new List<Produs>();

        SqlConnection con =
        new SqlConnection("Server=tcp:myazureserver01.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=dbadmin;Password=Radumihai81!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public FormReceptii(Utilizator util)
        {   
            InitializeComponent();

            u = (Utilizator)util.Clone();
            //MessageBox.Show(u.adresa);

            listaNIR.Clear();
            double valTotala = 0, valTVA = 0, valFaraTVA = 0;

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.receptie", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewNIR.DataSource = dt;
            setColumnName(dataGridViewNIR);
            con.Close();

            lblNrNIR.Text = dataGridViewNIR.RowCount.ToString();

            foreach (DataGridViewRow row in dataGridViewNIR.Rows)
            {
                valTotala += Double.Parse(row.Cells[6].Value.ToString());
                valTVA += Double.Parse(row.Cells[7].Value.ToString());
                valFaraTVA += Double.Parse(row.Cells[8].Value.ToString());
            }
            lbValoareTotala.Text = valTotala.ToString();
            lbValTVA.Text = valTVA.ToString();
            lbValFaraTVA.Text = valFaraTVA.ToString();
        }

        private void setColumnName(DataGridView dataGridViewNIR)
        {
            dataGridViewNIR.Columns[0].HeaderCell.Value = "Receptie";
            dataGridViewNIR.Columns[1].HeaderCell.Value = "Furnizor";
            dataGridViewNIR.Columns[2].HeaderCell.Value = "Tip";
            dataGridViewNIR.Columns[3].HeaderCell.Value = "Data";
            dataGridViewNIR.Columns[4].HeaderCell.Value = "Gestiune";
            dataGridViewNIR.Columns[5].HeaderCell.Value = "Comisie";
            dataGridViewNIR.Columns[6].HeaderCell.Value = "Valoare";
            dataGridViewNIR.Columns[7].HeaderCell.Value = "TVA";
            dataGridViewNIR.Columns[8].HeaderCell.Value = "Valoare fara TVA";
        }

        private void btnAddNIR_Click(object sender, EventArgs e)
        {
            FormAddNIR fadd = new FormAddNIR(u);
            fadd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaNIR.Clear();

            double valTotala = 0, valTVA = 0, valFaraTVA = 0;

            dataGridViewNIR.DataSource = null;
            dataGridViewNIR.Rows.Clear();


            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.receptie", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewNIR.DataSource = dt;
            setColumnName(dataGridViewNIR);
            con.Close();

            lblNrNIR.Text = dataGridViewNIR.RowCount.ToString();

            foreach (DataGridViewRow row in dataGridViewNIR.Rows)
            {
                valTotala += Double.Parse(row.Cells[6].Value.ToString());
                valTVA += Double.Parse(row.Cells[7].Value.ToString());
                valFaraTVA += Double.Parse(row.Cells[8].Value.ToString());
            }
            lbValoareTotala.Text = valTotala.ToString();
            lbValTVA.Text = valTVA.ToString();
            lbValFaraTVA.Text = valFaraTVA.ToString();

            tbSearchFurnizor.Text = "";
            dateTimePicker1.Value = new DateTime(2019, 01, 01);
            dateTimePicker2.Value = DateTime.Today;

        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            string excelTemplateFilePath = "C:\\Users\\Alina\\Desktop\\Proiect IPLA\\app\\app\\RaportTemplate.xlsx";
            var excelApp = new Excel.Application() as Excel._Application;
            var workbook = excelApp.Workbooks.Open(excelTemplateFilePath);

            Excel.Worksheet sheetData = workbook.Sheets[2];
            var dataRange = sheetData.get_Range("A2");
            dataRange.Value2 = 1;
            dataRange.AutoFill(sheetData.get_Range("A2", "A" + (listaNIR.Count + 1)),
            Excel.XlAutoFillType.xlFillSeries);

            for (int i = 0; i < listaNIR.Count; i++)
            {
                (sheetData.Cells[i + 2, 2] as Excel.Range).Value2 = listaNIR[i].id;
                (sheetData.Cells[i + 2, 3] as Excel.Range).Value2 = listaNIR[i].furnizor;
                (sheetData.Cells[i + 2, 4] as Excel.Range).Value2 = listaNIR[i].tip;
                (sheetData.Cells[i + 2, 5] as Excel.Range).Value2 = listaNIR[i].data.ToShortDateString();
                (sheetData.Cells[i + 2, 6] as Excel.Range).Value2 = listaNIR[i].gestiune;
                (sheetData.Cells[i + 2, 7] as Excel.Range).Value2 = listaNIR[i].comisie;
                (sheetData.Cells[i + 2, 8] as Excel.Range).Value2 = listaNIR[i].valoare;
                (sheetData.Cells[i + 2, 9] as Excel.Range).Value2 = listaNIR[i].valoareTVA;
                (sheetData.Cells[i + 2, 10] as Excel.Range).Value2 = listaNIR[i].valoareFaraTVA;
                (sheetData.Cells[i + 2, 13] as Excel.Range).Value2 = listaNIR[i].data.Month.ToString();
            }

            sheetData.get_Range("C2", "C" + (listaNIR.Count + 1)).Name = "Valori";
            sheetData.get_Range("H2", "H" + (listaNIR.Count + 1)).Name = "Val";
            sheetData.get_Range("M2", "M" + (listaNIR.Count + 1)).Name = "Luna";


            Excel.Worksheet sheetData2 = workbook.Sheets[3];
            var dataRange2 = sheetData2.get_Range("A2");
            dataRange2.Value2 = 1;
            dataRange2.AutoFill(sheetData2.get_Range("A2", "A" + (listaProduse.Count + 1)),
            Excel.XlAutoFillType.xlFillSeries);

            for (int i = 0; i < listaProduse.Count; i++)
            {
                (sheetData2.Cells[i + 2, 2] as Excel.Range).Value2 = listaProduse[i].id;
                (sheetData2.Cells[i + 2, 3] as Excel.Range).Value2 = listaProduse[i].denumire;
                (sheetData2.Cells[i + 2, 4] as Excel.Range).Value2 = listaProduse[i].um;
                (sheetData2.Cells[i + 2, 5] as Excel.Range).Value2 = listaProduse[i].cantitate;
                (sheetData2.Cells[i + 2, 6] as Excel.Range).Value2 = listaProduse[i].pret;
                (sheetData2.Cells[i + 2, 7] as Excel.Range).Value2 = listaProduse[i].valoare;
                (sheetData2.Cells[i + 2, 8] as Excel.Range).Value2 = listaProduse[i].valoareTVA;
                (sheetData2.Cells[i + 2, 9] as Excel.Range).Value2 = listaProduse[i].valoareFaraTVA;
                //       (sheetData2.Cells[i + 2, 10] as Excel.Range).Value2 = listaProduse[i].idNir;
            }
            sheetData2.get_Range("C2", "C" + (listaProduse.Count + 1)).Name = "Produs";
            excelApp.DisplayAlerts = false;

            string excelFilePath = "C:\\Users\\Alina\\Desktop\\Proiect IPLA\\app\\app\\Raport.xlsx";
            workbook.Close(SaveChanges: true, Filename: excelFilePath);
            excelApp.Quit();

            System.Diagnostics.Process.Start(excelFilePath);
        }

        private void tbSearchFurnizor_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from [dbo].[receptie] where denumire_furnizor like '%" + tbSearchFurnizor.Text + "%'";
            query+=" and data between '" + dateTimePicker1.Value.ToShortDateString() + "' and '" + dateTimePicker2.Value.ToShortDateString() + "'";

            dataGridViewNIR.DataSource = null;
            dataGridViewNIR.Rows.Clear();

            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(comm);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewNIR.DataSource = dt;
            setColumnName(dataGridViewNIR);
            con.Close();
            lblNrNIR.Text = dataGridViewNIR.RowCount.ToString();
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            dataGridViewNIR.DataSource = null;
            dataGridViewNIR.Rows.Clear();

            con.Open();
            //string query = "select * from dbo.receptie where data between '" + dateTimePicker1.Value.ToShortDateString() + "' and '" + dateTimePicker2.Value.ToShortDateString() + "'";
            string query = "select * from dbo.receptie where data between '" + dateTimePicker1.Value.ToShortDateString() + "' and '" + dateTimePicker2.Value.ToShortDateString() + "'";

            query += " and denumire_furnizor like '%" + tbSearchFurnizor.Text + "%'";


            SqlDataAdapter sdf = new SqlDataAdapter(query, con);
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            dataGridViewNIR.DataSource = sd;
            setColumnName(dataGridViewNIR);
            lblNrNIR.Text = dataGridViewNIR.RowCount.ToString();
            con.Close();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (dataGridViewNIR.SelectedRows.Count < 1)
            {

                MessageBox.Show("Selecteaza o receptie!");
            }
            else
            {
                int index = dataGridViewNIR.SelectedRows[0].Index;
                con.Open();
                string query = "DELETE FROM dbo.receptie WHERE id_receptie=" + dataGridViewNIR.SelectedRows[0].Cells[0].Value.ToString() + "";
                SqlCommand comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();
                string query2 = "DELETE FROM dbo.produs_receptie WHERE id_receptie=" + dataGridViewNIR.SelectedRows[0].Cells[0].Value.ToString() + "";
                SqlCommand comm2 = new SqlCommand(query2, con);
                comm2.ExecuteNonQuery();
                con.Close();
                dataGridViewNIR.Rows.RemoveAt(index);
                lblNrNIR.Text = dataGridViewNIR.RowCount.ToString();
                MessageBox.Show("NIR sters cu succes!");

            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
      
            con.Open();
            string query = "select * from [dbo].[receptie] ";

            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(comm);

            DataTable dt = new DataTable();
            sda.Fill(dt);
          //  dataGridViewNIR.DataSource = dt;
            con.Close();

            Excel.Application excel=new Excel.Application();
            excel.Visible = false;
            excel.DisplayAlerts = false;
            Excel.Workbook excelworkBook = excel.Workbooks.Add(Type.Missing);
            Excel.Worksheet excelSheet = (Excel.Worksheet)excelworkBook.ActiveSheet;
            excelSheet.Name = "Test work sheet";

            excelSheet.Cells[1, 1] = "Sample test data";
            excelSheet.Cells[1, 2] = "Date : " + DateTime.Now.ToShortDateString();

            Excel.Range excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[dt.Rows.Count, dt.Columns.Count]];
            excelCellrange.EntireColumn.AutoFit();
            Excel.Borders border = excelCellrange.Borders;
            border.LineStyle = Excel.XlLineStyle.xlContinuous;
            border.Weight = 2d;

            excelworkBook.Close(true);
            //inchiderea aplicației Excel
            excel.Quit();
            //inchiderea aplicației părinte
            //Application.Exit();

        }

        //find and replace
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


        //nu se salveaza
        private void btnWord22_Click(object sender, EventArgs e)
        {
            List<Produs> listaProduseW = new List<Produs>();

            NIR nirW = new NIR();
            nirW.id = Int32.Parse(dataGridViewNIR.SelectedRows[0].Cells[0].Value.ToString());
            nirW.furnizor = dataGridViewNIR.SelectedRows[0].Cells[1].Value.ToString();
            nirW.tip = dataGridViewNIR.SelectedRows[0].Cells[2].Value.ToString();
            nirW.data = DateTime.Parse(dataGridViewNIR.SelectedRows[0].Cells[3].Value.ToString()).Date;
            nirW.gestiune = dataGridViewNIR.SelectedRows[0].Cells[4].Value.ToString();
            nirW.comisie = dataGridViewNIR.SelectedRows[0].Cells[5].Value.ToString();
            nirW.valoare = Double.Parse(dataGridViewNIR.SelectedRows[0].Cells[6].Value.ToString());
            nirW.valoareTVA = Double.Parse(dataGridViewNIR.SelectedRows[0].Cells[7].Value.ToString());
            nirW.valoareFaraTVA = Double.Parse(dataGridViewNIR.SelectedRows[0].Cells[8].Value.ToString());

            int id_receptie = Int32.Parse(dataGridViewNIR.SelectedRows[0].Cells[0].Value.ToString());
            
            con.Open();
            string query = "select * from dbo.produs_receptie where id_receptie="+id_receptie+";";

            SqlCommand comm = new SqlCommand(query, con);
            SqlDataReader dbReader = comm.ExecuteReader();
            while (dbReader.Read())
            {
                Produs p = new Produs();
                p.denumire = dbReader.GetValue(1).ToString();
                p.um = dbReader.GetValue(2).ToString();
                p.cantitate = Double.Parse(dbReader.GetValue(3).ToString());
                p.pret = Double.Parse(dbReader.GetValue(4).ToString());
                p.valoare = Double.Parse(dbReader.GetValue(5).ToString());
                p.valoareTVA = Double.Parse(dbReader.GetValue(6).ToString());
                p.valoareFaraTVA = Double.Parse(dbReader.GetValue(7).ToString());

                listaProduseW.Add(p);
            }
            con.Close();

            object filename = @"C:\Users\Alina\Desktop\Proiect IPLA\app\app\TemplateNIR2.docx";

            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = true;

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

                foreach (Produs p in listaProduseW)
                {
                    sbDenumire.Append(p.denumire).AppendLine();
                    int index = listaProduseW.IndexOf(p) + 1;
                    sbNr.Append(index).AppendLine();
                    sbUm.Append(p.um).AppendLine();
                    sbCantitate.Append(p.cantitate).AppendLine();
                    sbPret.Append(p.pret).AppendLine();
                    double valoare = p.pret * p.cantitate;
                    sbValoare.Append(valoare).AppendLine();
                }

                this.FindAndReplace(wordApp, "<data>", nirW.data.ToShortDateString().ToString());
                this.FindAndReplace(wordApp, "<gestiune>", nirW.gestiune.ToString());
                this.FindAndReplace(wordApp, "<idNir>", nirW.id.ToString());
                this.FindAndReplace(wordApp, "<furnizor>", nirW.furnizor.ToString());
                this.FindAndReplace(wordApp, "<tip>", nirW.tip.ToString());
                this.FindAndReplace(wordApp, "<idNir2>", nirW.id.ToString());
                this.FindAndReplace(wordApp, "<nr>", sbNr.ToString());
                this.FindAndReplace(wordApp, "<denumire>", sbDenumire.ToString());
                this.FindAndReplace(wordApp, "<um>", sbUm.ToString());
                this.FindAndReplace(wordApp, "<cantitateCf>", sbCantitate.ToString());
                this.FindAndReplace(wordApp, "<cantitate>", sbCantitate.ToString());
                this.FindAndReplace(wordApp, "<pret>", sbPret.ToString());
                this.FindAndReplace(wordApp, "<valoare>", sbValoare.ToString());
                this.FindAndReplace(wordApp, "<comisie>", nirW.comisie.ToString());
                this.FindAndReplace(wordApp, "<comisie2>", nirW.comisie.ToString());

               // wordApp.Visible = true;

                bool save = false;
                if (MessageBox.Show("Doriti salvarea documentului?", "Salvati?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    save = true;
                }
                //inchiderea documentului
                wordApp.Visible = true;
                myWordDoc.Close(save);
                //inchiderea aplicației
            }
            else
            {
                MessageBox.Show("File not Found!");
            }
        }


        //BUN
        private void btnWord_Click(object sender, EventArgs e)
        {
            List<Produs> listaProduseW = new List<Produs>();

            NIR nirW = new NIR();
            nirW.id = Int32.Parse(dataGridViewNIR.SelectedRows[0].Cells[0].Value.ToString());
            nirW.furnizor = dataGridViewNIR.SelectedRows[0].Cells[1].Value.ToString();
            nirW.tip = dataGridViewNIR.SelectedRows[0].Cells[2].Value.ToString();
            nirW.data = DateTime.Parse(dataGridViewNIR.SelectedRows[0].Cells[3].Value.ToString()).Date;
            nirW.gestiune = dataGridViewNIR.SelectedRows[0].Cells[4].Value.ToString();
            nirW.comisie = dataGridViewNIR.SelectedRows[0].Cells[5].Value.ToString();
            nirW.valoare = Double.Parse(dataGridViewNIR.SelectedRows[0].Cells[6].Value.ToString());
            nirW.valoareTVA = Double.Parse(dataGridViewNIR.SelectedRows[0].Cells[7].Value.ToString());
            nirW.valoareFaraTVA = Double.Parse(dataGridViewNIR.SelectedRows[0].Cells[8].Value.ToString());

            int id_receptie = Int32.Parse(dataGridViewNIR.SelectedRows[0].Cells[0].Value.ToString());

            con.Open();
            string query = "select * from dbo.produs_receptie where id_receptie=" + id_receptie + ";";

            SqlCommand comm = new SqlCommand(query, con);
            SqlDataReader dbReader = comm.ExecuteReader();
            while (dbReader.Read())
            {
                Produs p = new Produs();
                p.denumire = dbReader.GetValue(1).ToString();
                p.um = dbReader.GetValue(2).ToString();
                p.cantitate = Double.Parse(dbReader.GetValue(3).ToString());
                p.pret = Double.Parse(dbReader.GetValue(4).ToString());
                p.valoare = Double.Parse(dbReader.GetValue(5).ToString());
                p.valoareTVA = Double.Parse(dbReader.GetValue(6).ToString());
                p.valoareFaraTVA = Double.Parse(dbReader.GetValue(7).ToString());

                listaProduseW.Add(p);
            }
            con.Close();

            object filename = @"C:\Users\Alina\Desktop\Disertatie\app\TemplateNIR.docx";
            object SaveAs = @"C:\Users\Alina\Desktop\Disertatie\app\Receptie_" + nirW.id.ToString() + ".docx";


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
                foreach (Produs p in listaProduseW)
                {
                    sbDenumire.Append(p.denumire).AppendLine();
                    int index = listaProduseW.IndexOf(p) + 1;
                    sbNr.Append(index).AppendLine();
                    sbUm.Append(p.um).AppendLine();
                    sbCantitate.Append(p.cantitate).AppendLine();
                    sbPret.Append(p.pret).AppendLine();
                    double valoare = p.pret * p.cantitate;
                    sbValoare.Append(valoare).AppendLine();
                }

                this.FindAndReplace(wordApp, "<denumire_firma>", u.denumire_firma);

                this.FindAndReplace(wordApp, "<data>", nirW.data.ToShortDateString().ToString());
                this.FindAndReplace(wordApp, "<gestiune>", nirW.gestiune.ToString());
                this.FindAndReplace(wordApp, "<idNir>", nirW.id.ToString());
                this.FindAndReplace(wordApp, "<furnizor>", nirW.furnizor.ToString());
                this.FindAndReplace(wordApp, "<tip>", nirW.tip.ToString());
                this.FindAndReplace(wordApp, "<idNir2>", nirW.id.ToString());
                this.FindAndReplace(wordApp, "<nr>", sbNr.ToString());
                this.FindAndReplace(wordApp, "<denumire>", sbDenumire.ToString());
                this.FindAndReplace(wordApp, "<um>", sbUm.ToString());
                this.FindAndReplace(wordApp, "<cantitateCf>", sbCantitate.ToString());
                this.FindAndReplace(wordApp, "<cantitate>", sbCantitate.ToString());
                this.FindAndReplace(wordApp, "<pret>", sbPret.ToString());
                this.FindAndReplace(wordApp, "<valoare>", sbValoare.ToString());
                this.FindAndReplace(wordApp, "<comisie>", nirW.comisie.ToString());
                this.FindAndReplace(wordApp, "<comisie2>", nirW.comisie.ToString());
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
           // MessageBox.Show("NIR salvat!");

            System.Diagnostics.Process.Start(SaveAs.ToString());

        }

    }



}
    

