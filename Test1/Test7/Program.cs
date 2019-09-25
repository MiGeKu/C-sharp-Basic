using System;

namespace Test7
{
    class Program
    {
        static void Main(string[] args)
        {
            double whisky = double.Parse(Console.ReadLine());
            double qtybeer = double.Parse(Console.ReadLine());
            double qtywine = double.Parse(Console.ReadLine());
            double qtyrakia = double.Parse(Console.ReadLine());
            double qtywiski = double.Parse(Console.ReadLine());
            double pricerakia = whisky * 0.5;
            double pricewine = pricerakia - (pricerakia * 0.4);
            double pricebeer = pricerakia - (pricerakia * 0.8);
            double beer = (qtybeer * pricebeer);
            double wine = (qtywine * pricewine);
            double rakia = (qtyrakia * pricerakia);
            double whisky1 = (qtywiski * whisky);
            double sum = beer + whisky1 + wine + rakia;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
