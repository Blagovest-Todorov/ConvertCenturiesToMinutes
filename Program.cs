using System;
using System.Numerics;

namespace PoundsDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte inputNum = byte.Parse(Console.ReadLine());
            // centuries
            ushort years = (ushort)(100 * inputNum);         // to years
            int days = (int)(years * 365.2422);                // to days
            uint hours = (uint)days * 24;                       // to hours
            long minutes = hours * 60;                    // to minutes

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
                inputNum, years, days, hours, minutes);
        }
    }
}
