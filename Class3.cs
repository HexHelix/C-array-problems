using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3) Write a program in C# Sharp to count the frequency of each element of an 
//array.
namespace ConsoleApp1
{
    internal class Class3
    {
        public void print()
        {
            int[] arr = { 1, 1, 1, 2, 5, 5, 6, 7, 333, 333, 0, -1, -1 };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int count = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[j] == arr[i])
                    {
                        count++;

                    }
                    else if (arr[i] != arr[j])
                    {

                        i = j - 1;

                        break;
                    }

                }
                
                    Console.WriteLine(arr[i] + ":" + (count + 1));
                
            }
            Console.ReadLine();
        }
    }
}
