using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceImobil
{
    public class Imobil
    {
        public string tipCasa { get; set; }
        public int nrEtaje { get; set; }
        public double pret { get; set; }

        public Imobil()
        {
            tipCasa = "";
            nrEtaje = 0;
            pret = 0.00;
        }
        public Imobil(string type)
        {
            this.tipCasa = type;
            this.nrEtaje = 0;
            this.pret = 0.00;

        }
        public Imobil(string model, int floor, double price)
        {
            this.tipCasa = model;
            this.nrEtaje = floor;
            this.pret = price;
        }

        public int NumarCamere()
        {
            return 2;
        }
    }
}
