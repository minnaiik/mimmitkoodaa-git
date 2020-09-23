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
            Console.WriteLine(luku);
           
    

        Console.WriteLine("Peli on päättynyt.");

        }
    }
}
