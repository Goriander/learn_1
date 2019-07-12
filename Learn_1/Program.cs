using System;                       //Used libraries
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learm_1                   //Program name space
{
    class Program                   //Class
    {
        static void Main()          //Standart main mathod
        {
            /* help hint
            DateTime dold = DateTime.Now;
            bool logic = true;
            string str = "Crar row";
            int a = 32;
            float b = 3.14f;
            double c = 6.33;
            TimeSpan sp = DateTime.Now - dold;
            Console.WriteLine(sp);
            */

            //cteate a random array
            int[] array = new int[100];
            Random rnd = new Random();
            for(int i=0;i<array.Length;i++)
            {
                array[i] = rnd.Next(101);
            }
            Console.WriteLine("Generated array:");
            PrintArray(array);

            DateTime start = DateTime.Now;
            array = SelectionSort(array);
            TimeSpan time = DateTime.Now - start;
            Console.WriteLine($"Selection sorting, time({time}):"); 
            PrintArray(array);
            

            Console.ReadKey();
        }
        static void PrintArray(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.Write($"[{array[i]}] ");
            }
            Console.WriteLine();
        }
        //Sorting algoritms

        //Selection sort
        static int[] SelectionSort(int[] array)
        {
            int start = 0;
            int end = array.Length;

            for(int i=0;i<end;i++)
            {
                int min = 32767;
                int temp = 0;
                int temp_index = 0;
                for (int j=start;j<end;j++)
                {
                    if (array[j]<min)
                    {
                        min = array[j];
                        temp_index = j;
                    }   
                }
                temp = array[start];
                array[temp_index] = temp;
                array[start] = min;
                start += 1;
            }
            return array;
        }
    }
}