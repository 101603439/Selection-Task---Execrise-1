using System;

namespace Sum_of_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
           int number;
           number = int.Parse(Console.ReadLine());

           Console.WriteLine("Enter the Second Number ");
           int number2;
           number2 = int.Parse(Console.ReadLine());

           int total = number + number2;

           if (total > 10)
            Console.WriteLine("Sum of numbers is greater than 10");
            else
            {
                if(total < 10)
                Console.WriteLine("Sum of numbers is less than 10");
            }
                if (total == 10)
                Console.WriteLine("Sum of numbers is equal to 10");
        
        }
    }
}
