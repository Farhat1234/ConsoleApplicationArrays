/*Input several numbers and stop when user enters “end”
Create a program which asks the user for several numbers (until he enters "end" and displays
their sum). When the execution is going to end, it must display all the numbers entered, and
the sum again, as follows:
Enter a number: 5
Sum = 5
Enter a number: 3
Sum = 8
Enter a number: end
The numbers are: 5 3
The sum is: 8
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0 ;
            Console.WriteLine("ENter a number");
            string str = Console.ReadLine();
            while (str != "end")
            {
                int i = int.Parse(str);
                sum += i ; 
                Console.WriteLine("sum : {0} " ,sum);
                Console.WriteLine("ENter a number");
                str=Console.ReadLine();
            }
            Console.WriteLine("sum is : {0}", sum);
        }
    }
}
