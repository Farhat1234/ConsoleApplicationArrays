/*Create a program to ask the user for 5 numbers, store them in an array and show them in
reverse order*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers");

            int[] array = new int[5];

            for(int i=0; i<5 ;i++)
            array[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Reversed numbers are:");

            for(int i=4;i>=0;i--)
                Console.WriteLine(array[i]);
        }
    }
}
