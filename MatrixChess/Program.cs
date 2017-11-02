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
            int[,] steps = { 
                { 1, 2 }, { -1, 2 }, 
                { 1, -2 }, { -1, -2 },
                { 2, 1 }, { -2, 1 },
                { 2, -1}, {-2, -1}
            };
           

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (o == 1)
                        matchess[i, j] = 1;
                    else
                        matchess[i, j] = steps[2,0];
                    o = -o;
                }
                if (n % 2 == 0)
                    o = -o;
            }
            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                { 
                    Console.Write("\t{0}", matchess[i, j]);                
                  
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
