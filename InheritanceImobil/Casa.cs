using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceImobil
{
    public class Casa : Imobil
    {
        int spatiuGradina { get; set; }

        public Casa(string model, int floor, double price, int spatiuGradina) : base()
        {
            this.spatiuGradina = spatiuGradina;
            this.nrEtaje = floor;
            this.pret = price;
            this.tipCasa = model;
        }

        public string InformatiiCasa()
        {
            return "\nImobilul este: casa" + "\nAre " + base.nrEtaje + " etaje \nCosta: " + base.pret + " euro\nSpatiul verde are: " + spatiuGradina + "mp";
        }

        public int NumarCamere()
        {
            return 5;
        }
    }
}
