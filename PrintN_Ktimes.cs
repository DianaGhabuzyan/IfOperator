using System;

namespace N_Ktimes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int resultK;
            int resultN;
            int a = 0;

            Console.WriteLine("Write any number(K)");
            resultK = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Say how many times (N) you want to print it (K)");
            resultN = Convert.ToInt32(Console.ReadLine());

            while (a < resultN)
            {
                Console.WriteLine(resultK);
                resultN--;
            }

            Console.ReadKey();
        }
    }
}




            