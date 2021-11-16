using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodniProjekt3.D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //varijable
            int ocjena, zbrojOcjena=0;
            double prosjek=0, brojOcjena = 0.0;

            //zaglavlje aplikacije
            Console.WriteLine("################################");
            Console.WriteLine("#    Izračunavanje prosjeka    #");
            Console.WriteLine("################################");

            do {
                //unos ocjene
                Console.WriteLine("Unesi ocjenu: ");
                Console.WriteLine("Za kraj unesi nulu.");
                ocjena = Convert.ToInt32(Console.ReadLine());

                //provjera ispravnosti unosa ocjena
                if (ocjena <= 5 && ocjena > 1)
                {

                    /*debug
                    Console.WriteLine("Ocjena je:" + ocjena);
                    */

                    //dodavanje ocjene u zbrojOcjena
                    zbrojOcjena += ocjena;

                    //brojanje predmeta
                    brojOcjena++;
                   

                    //izračun prosjeka
                    prosjek = zbrojOcjena / brojOcjena;
                }
                else if (ocjena == 1)
                {
                    prosjek = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Molim upišite ispravnu ocjenu.");
                }

                /*debug
                Console.WriteLine("Ocjena: " + ocjena);
                Console.WriteLine("Zbroj ocjena: " + zbrojOcjena);
                Console.WriteLine("Broj ocjena: " + brojOcjena);
                */
            }
            while (ocjena!=0);

            //Ispis prosjeka
            Console.WriteLine("Prosjek ocjena je:" + prosjek);


            //kraj aplikacije
            Console.ReadKey();
        }
    }
}
