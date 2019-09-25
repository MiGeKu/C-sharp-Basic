using System;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            var sportshall = (L * 100) * (W * 100);
            var wardrobe = (A*100)*(A*100);
            double bench = (sportshall / 10);
            double freespace = (sportshall - wardrobe - bench);
            double dancers = (freespace / (40 + 7000));
            Console.WriteLine(Math.Truncate(dancers));
        }
    }
}
