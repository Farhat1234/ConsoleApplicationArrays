/*Create a recursive function to calculate the factorial of the number specified as parameter:
Console.Write ( Factorial (6) );
would display 720*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static int Factorial(int n)
        {
            int num = 1;

            for (int i = 1; i <= n; i++)
            {
                num = num * i;
            }
            return num;
        }

        static void Main()
        {
            Console.WriteLine(Factorial(5));
        }
    }
}
