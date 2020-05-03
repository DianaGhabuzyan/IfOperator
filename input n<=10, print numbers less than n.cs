using System;

namespace problem3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int result;
            Console.WriteLine("Print the number from 1 to 10");
            result = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<result; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            
        }
    }
}
