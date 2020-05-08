using System;

namespace experiments
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //delaring the variables that we'll use

            int i, j,m, n=0;
            int [,] arr1 = new int[10, 10];
            int sumright = 0;
            int sumleft = 0;
      
            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;


            //taking the input elements [i,j] and saving them in a massive

            Console.Write("Input elements in the matrix \n:");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


           
            //representing the massive in a proper way and calculating the right and left diagonal

            Console.WriteLine("The matrix is: ");
            for (i=0;i<n;i++)
            {
                for (j=0;j<n;j++)
                {
                    Console.Write("{0}", arr1[i,j] + " ");
                    if (i == j) sumright += arr1[i, j];
                    if ((i+j==n-1)) sumleft += arr1[i,j];
                }
                Console.WriteLine();
               
            }
            Console.WriteLine("The sum of right diagonal is: {0}",sumright);
            Console.WriteLine("The sum of left diagonal is: {0}", sumleft);
            Console.ReadKey();
        }
    }
}
