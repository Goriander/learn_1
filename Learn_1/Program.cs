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
            foreach (int i in array)
            {
                array[i] = rnd.Next(101);
            }

            Console.ReadKey();
        }

        //Sorting algoritms

        //Selection sort
        static int[] SelectionSort(int[] array)
        {
            int start = 0;
            int end = array.Length;
            bool done = false;

            while (!done)
            {
                done = true;
                int min = 32767;
                int temp = 0;
                int temp_index = 0;
                for (int i=start;i<end;i++)
                {
                    if (array[i]<min)
                    {
                        min = array[i];
                        temp_index = i;
                        done = false;
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