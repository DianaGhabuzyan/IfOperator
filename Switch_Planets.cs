using System;

namespace IfElsestatment_example
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            int num;
            Console.WriteLine("Enter a number from 1 to 9 to know which planet corresponds to your number");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("The planet is Mercury");
                    break;
                case 2:
                    Console.WriteLine("The planet is Venus");
                    break;
                case 3:
                    Console.WriteLine("The planet is Earth");
                    break;
                case 4:
                    Console.WriteLine("The planet is Mars");
                    break;
                case 5:
                    Console.WriteLine("The planet is Jupiter");
                    break;
                case 6:
                    Console.WriteLine("The planet is Saturn");
                    break;
                case 7:
                    Console.WriteLine("The planet is Uranus");
                    break;
                case 8:
                    Console.WriteLine("The planet is Neptun");
                    break;
                case 9:
                    Console.WriteLine("The planet is Pluto");
                    break;

                    Console.ReadKey();

            }



        }
    }
}
