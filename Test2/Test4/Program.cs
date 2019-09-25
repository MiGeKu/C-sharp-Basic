using System;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            string outputmeasure = Console.ReadLine();

            double mm = 0;      
            
            if (measure == "m")
            {
                mm = number * 1000;
            }
            else if (measure == "cm")
            {
                mm = number * 10;
            }
            else
            {
                mm = number;
            }
            if (outputmeasure == "m")
            {
                number = mm / 1000;
            }
            else if (outputmeasure  == "cm")
            {
                number = mm / 10;
            }
            else
            {
                number = mm;
            }
            Console.WriteLine($"{number:F3}");
            }

        }
    }

