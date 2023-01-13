using System;

namespace Baskettball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taksa = int.Parse(Console.ReadLine());

            double kecove = taksa - (taksa * 0.40);
            double ekip = kecove - (kecove * 0.20);
            double topka = ekip / 4;
            double aksesoari = topka / 5;

            double total = kecove + ekip + topka + aksesoari + taksa;
            Console.WriteLine(total);

            
            
        }
    }
}
