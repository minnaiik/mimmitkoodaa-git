using System;

namespace Arvauspeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa pelaamaan Arvaa luku-peliä!");

            // arvotaan satunnainen luku, joka on oikea vastaus
            Random rand = new Random();
            int luku = rand.Next(1,21);
            // Console.WriteLine(luku);
            // annetaan pelaajalle 3 arvauskertaa
            int arvauskertoja = 0;
            while(arvauskertoja < 3) {

                Console.WriteLine("Anna arvaus väliltä 1-20");
                int arvaus = int.Parse(Console.ReadLine());

                if(arvaus < luku) {
                    Console.WriteLine("Oikea luku on suurempi.");

                }
                else if (arvaus > luku) {
                    Console.WriteLine("Oikea luku on pienempi.") {

                    }
                    else {
                        Console.WriteLine("Oikein! Voitit pelin!");
                    }
                    arvauskertoja++;
                }
            }
           
    

        Console.WriteLine("Peli on päättynyt.");

        }
    }
}
