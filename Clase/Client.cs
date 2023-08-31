using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Clase
{
    public class Client
    {
        public String denumire_client { get; set; }
        public String cif_client { get; set; }
        public String reg_com { get; set; }
        public String adresa { get; set; }
        public String localitate { get; set; }
        public String judet { get; set; }
        public String tara { get; set; }

        public Client() { }
        public Client(String dc, String cc, String rc, String a, String l, String j, String t) : this()
        {
            denumire_client = dc;
            cif_client = cc;
            reg_com = rc;
            adresa = a;
            localitate = l;
            judet = j;
            tara = t;

        }

    }
}
