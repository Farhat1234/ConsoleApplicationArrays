/*Write a C# program to ask the user for 10 integer numbers and
display the even ones.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers");

            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
                array[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Even numbers are:");

            for (int i = 0; i < 10; i++)
                if (array[i] % 2 == 0)
                    Console.WriteLine(array[i]);
        }
    }
}

