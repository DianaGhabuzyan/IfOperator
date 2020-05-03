using System;

namespace IfElsestatment_example
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a number from 1 to 9 to know which planet corresponds to your number");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number == 1)
            {
                Console.WriteLine("The planet is Mercury");
            }
            else if (number == 2)
            {
                Console.WriteLine("The planet is Venus");
            }
            else if (number == 3)
            {
                Console.WriteLine("The planet is Earth");
            }
            else if (number == 4)
            {
                Console.WriteLine("The planet is Mars");
            }
            else if (number == 5)
            {
                Console.WriteLine("The planet is Jupiter");
            }
            else if (number == 6)
            {
                Console.WriteLine("The planet is Saturn");
            }
            else if (number == 7)
            {
                Console.WriteLine("The planet is Uranus");
            }
            else if (number == 8)
            {
                Console.WriteLine("The planet is Neptun");
            }
            else if (number == 9)
            {
                Console.WriteLine("The planet is Pluto");
            }

            Console.ReadKey();
        }
    }
}
