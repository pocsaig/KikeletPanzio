using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace KikeletPanzio_PocsaiG
{
    public class Szoba
    {
        int szobaSzam;
        int ferohely;
        int ar;
        bool foglalt;

        public Szoba(int szobaSzam, int ferohely, int ar, bool foglalt)
        {
            this.SzobaSzam = szobaSzam;
            this.Ferohely = ferohely;
            this.Ar = ar;
            this.Foglalt = foglalt;
        }

        public int SzobaSzam { get => szobaSzam; set => szobaSzam = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
        public int Ar { get => ar; set => ar = value; }
        public bool Foglalt { get => foglalt; set => foglalt = value; }
    }
}
