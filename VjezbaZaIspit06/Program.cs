using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspit06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- PRVI ZADATAK -----");
            /*
             * Napišite program koji će od korisnika uzeti string, 
             * te definirajte i ispišite novi string koji će sadržavati sve znakove unešenog stringa osim prva dva i zadnja dva znaka. 
             * Ako je niz dužine manje od 5 znakova treba ispisati cijeli niz.
             */

            Console.WriteLine("Unesi string: ");
            string prviString = Console.ReadLine();
            if (prviString.Length < 5)
            {
                Console.WriteLine("String je manji od pet znakova: " + prviString);
            }
            else
            {
                string prviString2 = prviString.Substring(2, prviString.Length - 4);
                Console.WriteLine("String osim prva i zadnja dva znaka je: " + prviString2);
            }


            Console.WriteLine("\n----- ZADATAK 2 -----");
            /*Napišite program koji će provjeriti jesu li vrijednosti sadržane u int varijablama x, y i z stranice pravokutnog trokuta. 
             * U program uključite i provjeru da vrijednosti varijabli za ovakav primjer imaju smislene vrijednosti 
             * (iznosi moraju biti veći od 0).
            */

            int x, y, z;
            nazad: Console.WriteLine("Unesi stranicu x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi stranicu y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi stranicu z: ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x < 0 || y < 0 || z < 0)
            {
                Console.WriteLine("Neispravan unos, pokušaj ponovno!");
                goto nazad;
            }
            if(Math.Pow(z, 2) == Math.Pow(x,2) + Math.Pow(y,2))
            {
                Console.WriteLine("Trokut je pravokutan!");
            }
            else
            {
                Console.WriteLine("Trokut nije pravokutan :(");
            }


            Console.WriteLine("\n----- ZADATAK 3 -----");
            /*Napišite program koji će zatražiti od korisnika da unese broj te će u ovisnosti o unešenom
            broju ispisati jednu od sljedeće 4 poruke:
            • Broj je djeljiv s 4
            • Broj je djeljiv s 6
            • Broj je djeljiv sa 4 i sa 6
            • Broj nije djeljiv sa 4 ni sa 6
            Ako je broj djeljiv i sa 4 i sa 6 mora se ispisati poruka “Broj je djeljiv sa 4 i sa 6”
            */

            int broj;
            Console.WriteLine("Unesi broj: ");
            broj = Convert.ToInt32(Console.ReadLine());

            if(broj % 4 == 0 && broj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv s 4 i sa 6");
            }
            else if(broj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv s 6");
            }
            else if(broj % 4 == 0 )
            {
                Console.WriteLine("Broj je djeljiv s 4");
            }
            else if (broj % 4 != 0 || broj % 6 != 0 )
            {
                Console.WriteLine("Broj nije djeljiv s 4 ni sa 6");
            }


            Console.WriteLine("\n----- ZADATAK 4 -----");
            /*Napišite program koji će izračunati vrijednost PDV-a 
             na osnovu od korisnika unešenih cijena bez PDV-a i s PDV-om.
            */

            double bezPDV, saPDV;
            Console.WriteLine("Unesi cjenu bez PDV-a: ");
            bezPDV = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi cijenu sa PDV-om: ");
            saPDV = Convert.ToDouble(Console.ReadLine());
            double PDV = saPDV - bezPDV;
            Console.WriteLine("PDV je: {0}", PDV);


            Console.ReadKey();
        }
    }
}
