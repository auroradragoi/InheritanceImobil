using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceImobil
{
    public class Apartament : Imobil
    {
        public int etaj { get; set; }
        public Apartament(int etaj) : base()
        {
            this.etaj = etaj;
        }
        public int NumarCamere()
        {
            return 3;
        }

        public string InformatiiApartament()
        {
            return "Imobilul este: apartament" + "\nAre " + base.nrEtaje + " etaje \nCosta: " + base.pret + " euro \nse afla la etajul: " + etaj;
        }
    }
}
