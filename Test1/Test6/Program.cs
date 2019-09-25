using System;

namespace Test6
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioner = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            int moneyc = cakes * 45;
            double moneywaffles = waffles * 5.80;
            double moneypancakes = pancakes * 3.20;
            double moneyday = (moneyc + moneywaffles + moneypancakes) * confectioner;
            double moneyall = moneyday * days;
            double final = moneyall - (moneyall / 8);
            Console.WriteLine("{0:F2}", final);
        }
    }
}
