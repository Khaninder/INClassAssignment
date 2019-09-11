using System;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many yrs exp do you have");
            try
            {
                int exp = int.Parse(Console.ReadLine());
                int i = 0;
                for (i = 0; i < exp; i++)
                {
                    Console.WriteLine("You have " + exp.ToString() + " Of Experience");
                }
                Console.ReadLine();
            }
            catch
            {

                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
        }

    }
}
