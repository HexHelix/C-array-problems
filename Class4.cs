using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        public void print()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, -1, 9999};
            int min = arr[0], max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                else if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("min:"+min + " " + "max:" + max);
            Console.ReadLine();
        }
    }
}
