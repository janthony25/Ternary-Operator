using System;

namespace TernaryOperator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // (condition) ? x : y

            double temperature = 20;

          string message =  (temperature >= 15) ? "It is hot outside!" : "It is cold outside!";

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}