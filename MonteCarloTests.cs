using System;

namespace MonteCarlo
{
    public class MonteCarloTests
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var arrayLength = Convert.ToInt32(Console.ReadLine());

            var coords = new Coords[arrayLength];
            var random = new Random();
            var counter = 0;

            for (var i = 0; i < arrayLength; i++)
            {
                coords[i] = new Coords(random);
                if (coords[i].Hypotenuse() <= 1) counter++;
            }

            // Divide coordinates overlapping circle by the number of elements then multiply
            // value by four.
            var avg = counter / (double) coords.Length * 4;
          
            Console.WriteLine($"Points overlapping circle - {counter}");
            
            Console.WriteLine($"generated = {avg}, actual = {Math.PI}, difference = {Math.Abs(Math.PI - avg)}");
            Console.ReadKey();
        }
    }
}