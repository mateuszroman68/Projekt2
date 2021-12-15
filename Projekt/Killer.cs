using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Killer
    {
        


        public string Imie { get; set; }
        public string nazwisko { get; set; }
        public string  pseudonim { get; set; }
        public string kraj { get; set; }
        public string liczbaOfiar { get; set; }
        public string lataDzialania { get; set; }


        public Killer (string Imie,string nazwisko,string psudonim,string kraj,string liczbaOfiar,string lataDziałania)
        {
            this.Imie = Imie;
            this.nazwisko = nazwisko;
            this.pseudonim = pseudonim;
            this.kraj = kraj;
            this.liczbaOfiar = liczbaOfiar;
            this.lataDzialania = lataDzialania;
        }

        public Killer()
        { }

        public Killer(Killer killer)
        {
            this.Imie = killer.Imie;
            this.nazwisko = killer.nazwisko;
            this.pseudonim = killer.pseudonim;
            this.kraj = killer.kraj;
            this.liczbaOfiar = killer.liczbaOfiar;
            this.lataDzialania = killer.lataDzialania;
        }
        

    }
}
