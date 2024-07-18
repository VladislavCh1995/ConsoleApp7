using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                { 1,3,4 },
                { 2,4,8 },
                { 3,6,12 }
            };
            Console.WriteLine(array[1,1]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j<array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
