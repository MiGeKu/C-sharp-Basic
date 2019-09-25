using System;

namespace finishtest
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneye = double.Parse(Console.ReadLine());
            double moneys = double.Parse(Console.ReadLine());
            double moneyh = double.Parse(Console.ReadLine());
            double Z = moneye + moneyh + moneys;
            Console.WriteLine($"Money needed: {Z}");
        }
    }
}
