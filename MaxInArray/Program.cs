/*Create a function which returns the greatest value stored in an array of real
numbers which is specified as parameter:
float[] data={1.5f, 0.7f, 8.0f}
float max = Maximum(data);*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] data = { 1.5f, 9.7f, 8.0f };
            float max = Maximum(data);
            Console.WriteLine(max);
        }

        static float Maximum(float[] list)
        {
            float max = -99999999.00f;
            for (int i = 0; i < list.Length; i++)
            {
                if (i == 0)
                {
                    max = list[i];
                }
                else if (max < list[i])
                {
                    max = list[i];
                }               
            }
            Console.WriteLine("Maximum in the array is:\n ");
            return max;
        }
    }
}
