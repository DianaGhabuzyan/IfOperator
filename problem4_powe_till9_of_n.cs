using System;

namespace Problem4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Print the number");
            result = Convert.ToInt32(Console.ReadLine());
           
            for (int i=1;i<10;i++)
            {
                Console.WriteLine(Math.Pow(result,i));
            }

            Console.ReadKey();
        }
    }
}
