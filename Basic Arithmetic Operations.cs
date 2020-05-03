using System;

namespace Types_and_operations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = -5;
            uint b = 5;
            char c = 'D';
            float d = 9.9F;
            double e = 9.9;
            decimal f = 9.9M;
            bool g = true;
            string h = "Bonjour";

            // basic calculator model

            int num1, num2;
            int add, sub, mul, rem;
            float div;

            // accepting values from users

            Console.WriteLine("Enter first number\t\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number\t\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            //stating the operations

            add = num1 + num2;
            sub = num1 + num2;
            mul = num1 * num2;
            div = (float)num1 / num2; // cast operator (float) - A cast is a special
            //operator that forces one data type to be converted into another. A
            rem = num1 % num2; 
           

            //printing the output

            Console.WriteLine("Addition\t\t{0}", add);
            Console.WriteLine("Subtraction\t\t{0}", sub);
            Console.WriteLine("Multiplication\t\t{0}", mul);
            Console.WriteLine("Division\t\t{0}", div);
            Console.WriteLine("Remainder\t\t{0}", rem);

            Console.ReadKey(); 



        }
    }
}
