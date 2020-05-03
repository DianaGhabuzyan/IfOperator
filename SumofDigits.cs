using System;

namespace miniproblems
{
    class MainClass
    {
        public static void Main(string[] args)
        {  

            int number;
            int remainder;
            int sum=0;

            //get the number from the user and convert it
            Console.WriteLine("Please enter your number");
            number = Convert.ToInt32(Console.ReadLine());

            //get the remainder of that number to get the last digits
            while (number > 0)
            {
                remainder = number % 10;
                sum = remainder + sum;
                //divide by 10 to get the first digit
                number = number / 10;
            }
            
            Console.WriteLine("Sum of the digits is {0}", sum);

            Console.ReadKey();
        }
    }
}
