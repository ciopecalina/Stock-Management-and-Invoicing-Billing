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
using System.Windows.Forms.DataVisualization.Charting;

namespace app
{
    public partial class FormRaport : Form
    {   Utilizator u;
        SqlConnection con =
        new SqlConnection("Server=tcp:myazureserver01.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=dbadmin;Password=Radumihai81!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public FormRaport(Utilizator util)
        {
            InitializeComponent();

            u = (Utilizator)util.Clone();
            tableLayoutPanel2.Focus();
            
            con.Open();

            String query = "SELECT denumire_furnizor, count(denumire_furnizor)as nr FROM receptie GROUP BY denumire_furnizor ORDER BY denumire_furnizor ";
            SqlCommand cmd =
                new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet st = new DataSet();
            sda.Fill(st, "Series1");

            chart3.DataSource = st.Tables["Series1"];
            chart3.Series["Series1"].XValueMember = "denumire_furnizor";
            chart3.Series["Series1"].YValueMembers = "nr";
            this.chart3.Titles.Add("Nr. comenzi / Furnizor");
            chart3.Series["Series1"].ChartType = SeriesChartType.Doughnut;
            chart3.Series["Series1"].IsValueShownAsLabel = true;

            String query4 = "SELECT denumire_furnizor, sum(CONVERT(float, valoare)) as valoare FROM receptie GROUP BY denumire_furnizor ORDER BY denumire_furnizor ";
            SqlCommand cmd4 =
                new SqlCommand(query4, con);
            SqlDataAdapter sda4 = new SqlDataAdapter(cmd4);
            DataSet st4 = new DataSet();
            sda4.Fill(st4, "Series4");

            chart4.DataSource = st4.Tables["Series4"];
            chart4.Series["Series4"].XValueMember = "denumire_furnizor";
            chart4.Series["Series4"].YValueMembers = "valoare";
            this.chart4.Titles.Add("Valoare Totala comenzi / Furnizor");
            chart4.Series["Series4"].ChartType = SeriesChartType.Doughnut;
            chart4.Series["Series4"].IsValueShownAsLabel = true;

            String query5 = "SELECT luna, sum(CONVERT(float, valoare)) as valoare FROM dbo.receptii GROUP BY luna";
            SqlCommand cmd5 =
                new SqlCommand(query5, con);
            SqlDataAdapter sda5 = new SqlDataAdapter(cmd5);
            DataSet st5 = new DataSet();
            sda5.Fill(st5, "Series5");

            chart5.DataSource = st5.Tables["Series5"];
            chart5.Series["Series5"].XValueMember = "luna";
            chart5.Series["Series5"].YValueMembers = "valoare";
            this.chart5.Titles.Add("Valoare Totala comenzi / Luna");
            chart5.Series["Series5"].ChartType = SeriesChartType.Doughnut;
            chart5.Series["Series5"].IsValueShownAsLabel = true;

            String query6 = "SELECT luna, count(luna) as nr  FROM dbo.receptii GROUP BY luna";
            SqlCommand cmd6 =
                new SqlCommand(query6, con);
            SqlDataAdapter sda6 = new SqlDataAdapter(cmd6);
            DataSet st6 = new DataSet();
            sda6.Fill(st6, "Series6");

            chart6.DataSource = st6.Tables["Series6"];
            chart6.Series["Series6"].XValueMember = "luna";
            chart6.Series["Series6"].YValueMembers = "nr";
            this.chart6.Titles.Add("Nr. comenzi / Luna");
            chart6.Series["Series6"].ChartType = SeriesChartType.Doughnut;
            chart6.Series["Series6"].IsValueShownAsLabel = true;

            String query7 = "SELECT luna, sum(CONVERT(float, valoare)) as valoare FROM dbo.receptii GROUP BY luna";
            SqlCommand cmd7 =
                new SqlCommand(query7, con);
            SqlDataAdapter sda7 = new SqlDataAdapter(cmd7);
            DataSet st7 = new DataSet();
            sda7.Fill(st7, "Valoare Comenzi");

            chart7.DataSource = st7.Tables["Valoare Comenzi"];
            chart7.Series["Valoare Comenzi"].XValueMember = "luna";
            chart7.Series["Valoare Comenzi"].YValueMembers = "valoare";
            this.chart7.Titles.Add("Trend valoare comenzi pe an");
            chart7.Series["Valoare Comenzi"].ChartType = SeriesChartType.SplineRange;
            chart7.Series["Valoare Comenzi"].IsValueShownAsLabel = true;

            String query8 = "SELECT luna, count(luna) as nr  FROM dbo.receptii GROUP BY luna";
            SqlCommand cmd8 =
                new SqlCommand(query8, con);
            SqlDataAdapter sda8 = new SqlDataAdapter(cmd8);
            DataSet st8 = new DataSet();
            sda8.Fill(st8, "Nr. Comenzi");

            chart8.DataSource = st8.Tables["Nr. Comenzi"];
            chart8.Series["Nr. Comenzi"].XValueMember = "luna";
            chart8.Series["Nr. Comenzi"].YValueMembers = "nr";
            this.chart8.Titles.Add("Trend nr. comenzi pe an");
            chart8.Series["Nr. Comenzi"].ChartType = SeriesChartType.SplineRange;
            chart8.Series["Nr. Comenzi"].IsValueShownAsLabel = true;

            //tabel 1
            String query9 = "SELECT denumire_furnizor as Furnizor, count(denumire_furnizor) as Nr_comenzi, FORMAT(sum(CONVERT(float, valoare)), 'N2') as Valoare FROM receptie GROUP BY denumire_furnizor ORDER BY denumire_furnizor";
            SqlCommand cmd9 =
                new SqlCommand(query9, con);
            SqlDataAdapter sda9 = new SqlDataAdapter(cmd9);
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);
            dgvFurnizori.DataSource = dt9;

            dgvFurnizori.AutoResizeColumns();
            dgvFurnizori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //tabel 2
            String query10 = "SELECT luna as Luna, count(luna) as Nr_comenzi, FORMAT(sum(CONVERT(float, valoare)), 'N2') as Valoare FROM receptii GROUP BY luna ORDER BY luna";
            SqlCommand cmd10 =
                new SqlCommand(query10, con);
            SqlDataAdapter sda10 = new SqlDataAdapter(cmd10);
            DataTable dt10 = new DataTable();
            sda10.Fill(dt10);
            dvgComenzi.DataSource = dt10;

            dvgComenzi.AutoResizeColumns();
            dvgComenzi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            string queryP = "select count(denumire_produs), FORMAT(sum(CONVERT(float, valoare)),'N2') from produs_stoc";
         
            SqlCommand cp = new SqlCommand(queryP, con);
            SqlDataReader rp = cp.ExecuteReader();
            while (rp.Read())
            {
                lblNrProduse.Text = rp.GetValue(0).ToString();
                lblValoareProduse.Text = rp.GetValue(1).ToString()+" (Lei)";
            }
            rp.Close();

            string queryC = "select count(denumire_client) from client";
            SqlCommand cc = new SqlCommand(queryC, con);
            SqlDataReader rc = cc.ExecuteReader();
            while (rc.Read())
            {
                lblNrClienti.Text = rc.GetValue(0).ToString();
            }
            rc.Close();

            string queryF = "select count(denumire_furnizor) from furnizor";
            SqlCommand cf = new SqlCommand(queryF, con);
            SqlDataReader rf = cf.ExecuteReader();
            while (rf.Read())
            {
                lblNrFurni.Text = rf.GetValue(0).ToString();
            }
            rf.Close();

            string queryFnr = "select count(*) from emitere";
            SqlCommand cfnr = new SqlCommand(queryFnr, con);
            SqlDataReader rfnr = cfnr.ExecuteReader();
            while (rfnr.Read())
            {
                lblNrFacturi.Text = rfnr.GetValue(0).ToString();
            }
            rfnr.Close();

            string queryFnv = "select FORMAT(sum(CONVERT(float, valoare)),'N2') from emitere";
            SqlCommand cfnv = new SqlCommand(queryFnv, con);
            SqlDataReader rfnv = cfnv.ExecuteReader();
            while (rfnv.Read())
            {
                lblValoareFacturi.Text = rfnv.GetValue(0).ToString()+" (Lei)";
            }
            rfnv.Close();

            string queryRnr = "select count(*) from receptie";
            SqlCommand crnr = new SqlCommand(queryRnr, con);
            SqlDataReader rrnr = crnr.ExecuteReader();
            while (rrnr.Read())
            {
                lblNeReceptii.Text = rrnr.GetValue(0).ToString();
            }
            rrnr.Close();

            string queryRvl = "select FORMAT(sum(CONVERT(float, valoare)),'N2') from receptie";
            SqlCommand cvl = new SqlCommand(queryRvl, con);
            SqlDataReader rvl = cfnv.ExecuteReader();
            while (rvl.Read())
            {
                lblValoareReceptii.Text = rvl.GetValue(0).ToString() + " (Lei)";
            }
            rvl.Close();


            con.Close();
        }

    }
}
