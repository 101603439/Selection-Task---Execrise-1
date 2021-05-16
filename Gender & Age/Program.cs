using System;

namespace Gender___Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your Gender: ");
            string Gender = Console.ReadLine();
    
            Console.Write("Please enter you age: ");
            string age = Console.ReadLine();

            int ageNum = int.Parse(age);

            if(ageNum >= 17)
            Console.WriteLine("You are " +Gender+ " and is an adult");
            else
            {
                if(ageNum <17)
                Console.WriteLine("You are " +Gender+ " and is not an adult");
            }
        }
    }
}
