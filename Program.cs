using System;

namespace DataTypeTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());  //we read the input in meters
            float kilometers = meters / 1000.0F;
            Console.WriteLine($"{kilometers:F2}");

        }
    }
}
