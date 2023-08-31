using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectIPLA.Clase
{
    public class Utilizator : ICloneable
    {
        public String username { get; set; }
        public String parola { get; set; }
        public String denumire_firma { get; set; }
        public String cif{ get; set; }
        public String reg_com { get; set; }
        public String adresa { get; set; }
        public String localitate { get; set; }
        public String judet { get; set; }
        public String tara { get; set; }
        public String iban { get; set; }
        public String banca { get; set; }
        public String persoana_contact { get; set; }
        public String telefon { get; set; }
        public Utilizator() { }
        public Utilizator(String u, String p, String dc, String cc, String rc, String a, String l, String j, String t, String ibn, String bnc, String pc, String tel) : this()
        {
            username = u;
            parola = p;
            denumire_firma = dc;
            cif = cc;
            reg_com = rc;
            adresa = a;
            localitate = l;
            judet = j;
            tara = t;
            iban = ibn;
            banca = bnc;
            persoana_contact = pc;
            telefon = tel;

        }
        public Utilizator(String dc, String cc, String rc, String a, String l, String j, String t) : this()
        {
            denumire_firma = dc;
            cif = cc;
            reg_com = rc;
            adresa = a;
            localitate = l;
            judet = j;
            tara = t;

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}