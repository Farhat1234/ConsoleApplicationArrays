/*Create a function that tells if a string is an integer number. It should be used like this:
if (IsNumber ("1234"))
System.Console.WriteLine ("It is a numerical value");*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsInteger
{
    class Program
    {
        static bool IsNumber(string n)
        { 
           
            for (int i = 0; i < n.Length; i++ )
                if ((n[i] < '0') || (n[i] > '9'))
                {
                    return false;
                }
                    return true;
            
        }
        static void Main(string[] args)
        {

            if (IsNumber("1234"))
                System.Console.WriteLine("It is a numerical value\n");
            else
                System.Console.WriteLine("It is not a numerical value\n");
        }
    }
}
