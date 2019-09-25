using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double usd = double.Parse(Console.ReadLine());
            //double result = Math.Round ( 1.79549 * usd, 2); 
            //Console.WriteLine(result);
            double usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549 * usd;
            Console.WriteLine($"{bgn:F2}");
        }
    }
}
