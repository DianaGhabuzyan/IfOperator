using System;

namespace Problem5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int result;
            int sum = 0;
            Console.WriteLine("Print the number");
            result = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < result; i+=2)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }

            Console.ReadKey();
        }
    }
}
