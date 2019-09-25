using System;

namespace Test8
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal incomeInLv = decimal.Parse(Console.ReadLine());
            decimal averageSuccess = decimal.Parse(Console.ReadLine());
            decimal minimalSalary = decimal.Parse(Console.ReadLine());

            decimal socialScholarship = minimalSalary * 0.35m; //m - превръща числото в decimal
            decimal greatSuccess = averageSuccess * 25;

            if (averageSuccess < 4.5m && incomeInLv > minimalSalary && averageSuccess < 5.5m)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (incomeInLv < minimalSalary && averageSuccess > 4.5m)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if(averageSuccess > 5.5m)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(greatSuccess)} BGN");
            }
            else if(greatSuccess > socialScholarship)
                    {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(greatSuccess)} BGN");
            }
            else
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(socialScholarship)} BGN");
            }

        }
    }
}
