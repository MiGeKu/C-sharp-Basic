using System;

namespace Test7
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentrecordinseconds = double.Parse(Console.ReadLine());
            double distanceinmeters = double.Parse(Console.ReadLine());
            double secondspermeter = double.Parse(Console.ReadLine());

            double swimmingDelay = Math.Floor((distanceinmeters / 15))* 12.5;
            double CurrentTime = (distanceinmeters * secondspermeter) + swimmingDelay;

            if (currentrecordinseconds > CurrentTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {CurrentTime:F2} seconds." );
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(currentrecordinseconds - CurrentTime):F2} seconds slower.");
            }
        }
    }
}
