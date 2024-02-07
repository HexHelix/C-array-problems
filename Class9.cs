using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class9
    {
        public void print()
        {
            int n = 3;
            int[,] arr = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    sum+= arr[i,j];
                }
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
