/*Write a C# program to ask the user for marks for 20 pupils (2 groups of 10, using a
two-dimensional array), and display the average for each group.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] array = new float[10, 10];
            float sum = 0.0f, avg = 0.0f ;
            

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter the array {0} group {1}: ", j + 1, i + 1);
                    array[i, j] = Convert.ToSingle(Console.ReadLine());
                    sum = sum + array[i,j];
                }
                avg = sum / 10;
                Console.WriteLine("The average is " + avg);
                //Console.WriteLine(avg);
            }    
           
        }
    }
}
