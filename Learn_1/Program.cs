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
            int[] r_array = new int[100];
            Random rnd = new Random();
            for(int i=0;i<r_array.Length;i++)
            {
                r_array[i] = rnd.Next(101);
            }
            Console.WriteLine("Generated array:");
            PrintArray(r_array);

            int[] array1 = new int[r_array.Length];
            Array.Copy(r_array,array1,r_array.Length);
            DateTime start_time = DateTime.Now;
            array1 = SelectionSort(array1);
            TimeSpan time = DateTime.Now - start_time;
            Console.WriteLine($"Selection sorting, time({time}):"); 
            PrintArray(array1);

            int[] array2 = new int[r_array.Length];
            Array.Copy(r_array, array2, r_array.Length);
            start_time = DateTime.Now;
            array2 = InsertionSort(array2);
            time = DateTime.Now - start_time;
            PrintArray(r_array);
            Console.WriteLine($"Incertion sorting, time({time}):");
            PrintArray(array2);


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

        static int[] InsertionSort(int[] array)
        {
            bool done = false;
            int temp;
            while(!done)
            {
                done = true;
                for(int i=0;i<array.Length-1;i++)
                {
                    if (array[i+1]<array[i])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        done = false;
                    }
                }
            }
            return array;
        }
    }
}