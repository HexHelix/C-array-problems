using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class7
    {
        public void print()
        {
            string str = "HOMELANDER" ;
            int size = str.Length, k = 0 ;
            char[] newstr;
            newstr = new char[size];
            for(int i = size - 1; i >= 0; i--)
            {
                newstr[k] = str[i];
                k++;
            }
            Console.WriteLine(newstr);
            Console.ReadLine();

        }
    }
}
