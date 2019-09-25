using System;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Първи начин за решение на задачата

            //int h = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());

            //DateTime hm = DateTime.ParseExact($"{h}:{m}", "H:m", null);

            //hm = hm.AddMinutes(15);

            //Console.WriteLine(hm.ToString("H:mm"));

            int hour = int.Parse(Console.ReadLine()); // втори начин за решение на задачата
            int minute = int.Parse(Console.ReadLine());
            minute = minute + 15;
            if (minute > 59)
            {
                hour++;
                minute -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            if (minute < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, minute);

            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, minute);
            }
        }
    }
}

