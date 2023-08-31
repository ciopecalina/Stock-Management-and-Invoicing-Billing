using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Clase
{
    public class NIR
    {
        public int id { get; set; }
        public String furnizor { get; set; }
        public String tip { get; set; }
        public DateTime data { get; set; }
        public String gestiune { get; set; }
        public String comisie { get; set; }
        public double valoare { get; set; }
        public double valoareTVA { get; set; }
        public double valoareFaraTVA { get; set; }

        public NIR() { }
        public NIR(int i) : this()
        {
            id = i;
        }
        public NIR(int i, String f, String t, DateTime d,String g,String c) : this()
        {
            id = i;
            furnizor = f;
            tip = t;
            data = d;
            gestiune = g;
            comisie = c;
        }
        public NIR(int i, String f, String t, DateTime d, String g, String c, double v, double vT, double vft) : this()
        {
            id = i;
            furnizor = f;
            tip = t;
            data = d;
            gestiune = g;
            comisie = c;
            valoare = v;
            valoareFaraTVA = vft;
            valoareTVA = vT;
        }
    }
}
