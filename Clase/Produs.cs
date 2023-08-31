using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Clase
{
   public class Produs
    {
        public int id { get; set; }
        public String denumire { get; set; }
        public String um { get; set; }
        public double cantitate { get; set; }
        public double pret { get; set; }
        public double valoare { get; set; }
        public double valoareTVA { get; set; }
        public double valoareFaraTVA { get; set; }

        public Produs() { }
        public Produs(int i,String d, String u, double c, double p) : this()
        {
            id = i;
            denumire = d;
            pret = p;
            um = u;
            cantitate = c;
        }
       
        public Produs(String d,  Double c) : this()
        {
            denumire = d;
            cantitate = c;
        }
        public Produs(String d, String u, Double c, Double p) : this()
        {
            denumire = d;
            pret = p;
            um = u;
            cantitate = c;
        }
        public Produs(String d, String u, double c, double p, double v) : this()
        {
            denumire = d;
            pret = p;
            um = u;
            cantitate = c;
            valoare = v;
        }
        public Produs(int i, String d, String u, double c, double p, double v) : this()
        {
            id = i;
            denumire = d;
            pret = p;
            um = u;
            cantitate = c;
            valoare = v;
        }
        public Produs(String d, String u, double c, double p, double v, double vTVA, double vFTVA) : this()
        {
            denumire = d;
            pret = p;
            um = u;
            cantitate = c;
            valoare = v;
            valoareTVA = vTVA;
            valoareFaraTVA = vFTVA;
        }
        public Produs(int i, String d, String u, double c, double p, double v, double vTVA, double vFTVA) : this()
        {
            id = i;
            denumire = d;
            pret = p;
            um = u;
            cantitate = c;
            valoare = v;
            valoareTVA = vTVA;
            valoareFaraTVA = vFTVA;
        }

        double getValoare() {
            return (pret *cantitate * 1.19);
        }
        double getValoareTVA()
        {
            return (pret *cantitate * 1.19 - (pret *cantitate));
        }
        double getValoareFaraTVA()
        {
            return (pret * cantitate);
        }
    }
}
