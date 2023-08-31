using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Clase
{
    public class Factura
    {
        public String serie { get; set; }
        public String nr { get; set; }
        public String denumire_client { get; set; }
        public DateTime data { get; set; }
        public Double valoare { get; set; }
        public Double valoareTVA { get; set; }
        public Double valoareFaraTVA { get; set; }
        public String nume_emitent { get; set; }
        public String CNP_emitent { get; set; }
        public String aviz { get; set; }
        public String delegat { get; set; }
        public String buletin { get; set; }
        public String vehicul { get; set; }
        public String mentiuni { get; set; }

        public Factura()
        {
        }
        public Factura(String s, String n) : this()
        {
            serie = s;
            nr = n;
        }
        public Factura(String s, String n, String dc, DateTime d, Double v, Double vtva, Double vftva,
            String ne, String cnp, String a, String del, String b, String veh, String m ) : this()
        {
            serie = s;
            nr = n;
            denumire_client = dc;
            data = d;
            valoare = v;
            valoareFaraTVA = vftva;
            valoareTVA = vtva;
            nume_emitent = ne;
            CNP_emitent = cnp;
            aviz = a;
            delegat = del;
            buletin = b;
            vehicul = veh;
            mentiuni = m;

        }
        public Factura(String s, String n, String dc, DateTime d, 
            String ne, String cnp, String a, String del, String b, String veh, String m) : this()
        {
            serie = s;
            nr = n;
            denumire_client = dc;
            data = d;
            nume_emitent = ne;
            CNP_emitent = cnp;
            aviz = a;
            delegat = del;
            buletin = b;
            vehicul = veh;
            mentiuni = m;

        }
    }
}
