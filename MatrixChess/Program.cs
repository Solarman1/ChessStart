using System;

namespace MatrixChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix n size: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter matrix m size: ");
            int m = int.Parse(Console.ReadLine());

            int o = 1;

            int[,] matchess = new int[n, m];

            for(int i = 0; i<matchess.Length; i++)
            {
                for (int j = 0; j < matchess.Length; j++)
                    matchess[i, j] = o;
                    
            }
         
        }
    }
}
