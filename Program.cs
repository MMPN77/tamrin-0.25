using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;                                  //size of matrix (changable)
            int[,] map_in = new int[n, n];
            int[,] map_out = new int[n, n];
            Console.WriteLine("Please Enter number of 0 or 1 else number>1 convert to 1 and number<0 convert to 0");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                Console.WriteLine("Enter points of line of " + (i + 1) + " :");
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter point of column of " + (j + 1) + " :");
                    map_in[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (map_in[i, j] >= 1)
                        map_in[i, j] = 1;
                    else map_in[i, j] = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < n - 1)
                    {
                        if (map_in[i + 1, j] > 0)
                            map_out[i, j]++;
                    }

                    if (j < n - 1)
                    {
                        if (map_in[i, j + 1] > 0)
                            map_out[i, j]++;
                    }

                    if (i > 0)
                    {
                        if (map_in[i - 1, j] > 0)
                            map_out[i, j]++;
                    }

                    if (j > 0)
                    {
                        if (map_in[i, j - 1] > 0)
                            map_out[i, j]++;
                    }
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("matrix of proximity :");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {

                    Console.Write(map_out[i, j] + " ");
                }
            }
            Console.ReadKey();
        }

    }
}
