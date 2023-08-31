using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Furnizor
    {
        public String denumire_furnizor { get; set; }
        public String cif_furnizor { get; set; }
        public String reg_com { get; set; }
        public String adresa { get; set; }
        public String localitate { get; set; }
        public String judet { get; set; }
        public String tara { get; set; }
        public String iban { get; set; }
        public String banca { get; set; }

        public Furnizor() { }
        public Furnizor(String dc, String cc, String rc, String a, String l, String j, String t, String ibn, String bnc) : this()
        {
            denumire_furnizor = dc;
            cif_furnizor = cc;
            reg_com = rc;
            adresa = a;
            localitate = l;
            judet = j;
            tara = t;
            iban = ibn;
            banca = bnc;

        }
        public Furnizor(String dc, String cc, String rc, String a, String l, String j, String t) : this()
        {
            denumire_furnizor = dc;
            cif_furnizor = cc;
            reg_com = rc;
            adresa = a;
            localitate = l;
            judet = j;
            tara = t;

        }

    }
}
