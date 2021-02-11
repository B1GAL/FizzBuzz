using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1, 101);//generate a random number betw/ 1-100
            int divisableBy3Remainder = randomNbr;
            bool isDivisibleBy3 = divisableBy3Remainder == 0;
            
            if (randomNbr % 3 == 0
                && randomNbr % 5 == 0)
            {
                Console.WriteLine("Fizz");

            }
            else if (randomNbr % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randomNbr % 5 == 0 )
            {
                Console.WriteLine("Fizz");
            }
            
        }
    }
}
