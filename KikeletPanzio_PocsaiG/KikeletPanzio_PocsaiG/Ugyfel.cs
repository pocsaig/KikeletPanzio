using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikeletPanzio_PocsaiG
{
    public class Ugyfel
    {
        string azonosito;
         
        string nev;
        DateTime regIdopont;

        DateTime szuletesiDatum;
        string email;
        bool vip;
        bool visszatero;

        public Ugyfel(string nev, DateTime szuletesiDatum, string email, bool vip, bool visszatero)
        {
            RegIdopont = DateTime.Now;
            Nev = nev;
            Azonosito = nev + ", " + regIdopont.ToString();
            this.SzuletesiDatum = szuletesiDatum;
            this.Email = email;
            this.Vip = vip;
            this.Visszatero = visszatero;
        }

        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime RegIdopont { get => regIdopont; set => regIdopont = value; }
        public DateTime SzuletesiDatum { get => szuletesiDatum; set => szuletesiDatum = value; }
        public string Email { get => email; set => email = value; }
        public bool Vip { get => vip; set => vip = value; }
        public bool Visszatero { get => visszatero; set => visszatero = value; }
    }
}
