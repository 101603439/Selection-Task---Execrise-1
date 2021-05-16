using System;

namespace Legall_Adult_Age
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Please enter you age: ");
            string age = Console.ReadLine();

            int ageNum = int.Parse(age);

            if(ageNum >= 17)
            Console.WriteLine("Legally adult age");
            else
            {
                if(ageNum <17)
                Console.WriteLine("Legally not adult age");
            }

            Console.ReadLine();
        }
    }
}
