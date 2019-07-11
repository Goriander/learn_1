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

        //
    }
}