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
        string foglaltBy;
        DateTime foglaltStart;
        DateTime foglaltEnd;
        int foglaltForDays; 
        int foglaltOsszAr;

        public Szoba(int szobaSzam, int ferohely, int ar, bool foglalt, string foglaltBy, DateTime foglaltStart, DateTime foglaltEnd, int foglaltForDays, int foglaltOsszAr)
        {
            SzobaSzam = szobaSzam;
            Ferohely = ferohely;
            Ar = ar;
            Foglalt = foglalt;
            FoglaltBy = foglaltBy;
            FoglaltStart = foglaltStart;
            FoglaltEnd = foglaltEnd;
            FoglaltForDays = foglaltForDays;
            FoglaltOsszAr = foglaltOsszAr;
        }

        public int SzobaSzam { get => szobaSzam; set => szobaSzam = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
        public int Ar { get => ar; set => ar = value; }
        public bool Foglalt { get => foglalt; set => foglalt = value; }
        public string FoglaltBy { get => foglaltBy; set => foglaltBy = value; }
        public DateTime FoglaltStart { get => foglaltStart; set => foglaltStart = value; }
        public DateTime FoglaltEnd { get => foglaltEnd; set => foglaltEnd = value; }
        public int FoglaltForDays { get => foglaltForDays; set => foglaltForDays = value; }
        public int FoglaltOsszAr { get => foglaltOsszAr; set => foglaltOsszAr = value; }
        

        public string KIIR()
        {
            return $"Szobaszám: {szobaSzam}\nFérőhely: {ferohely}\nÁr/Éjszaka: {ar} Ft";
        }
    }
}
