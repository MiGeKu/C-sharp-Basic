using System;

namespace Test6
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double PricePerActor = double.Parse(Console.ReadLine());

            double PriceForClothing = actors * PricePerActor;
            double decor = budget * 0.10;

            if (actors > 150)
            {
                double discount = PriceForClothing * 0.10;
                PriceForClothing = PriceForClothing - discount;
            }

            double expeses = PriceForClothing + decor;

            if (expeses > budget)
            {
            
                double MoneyNeeded = expeses - budget;

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {MoneyNeeded:F2} leva more.");
            }
            else
            {
                double MoneyLeft = budget - expeses;

                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {MoneyLeft:F2} leva left.");
            }
        }
    }
}
