using System;

namespace InheritanceImobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartament apartament1 = new Apartament(4);
            apartament1.tipCasa = "ap";
            apartament1.nrEtaje = 1;
            apartament1.pret = 70000;
            Console.WriteLine(apartament1.InformatiiApartament());
            Console.WriteLine("Are " + apartament1.NumarCamere() + " camere");

            Casa casa1 = new Casa("casa", 2, 100000, 500);
            Console.WriteLine(casa1.InformatiiCasa());
            Console.WriteLine("Are " + casa1.NumarCamere() + " camere");
         }
    }
}
