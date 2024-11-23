using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignments
{
    public class SecondMax
    {
        public static void FindSecondHigh(int[] a)
        {
            int max1 = 0, max2 = 0;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] > max1)
                {
                    max2 = max1;
                    max1 = a[i];

                }
                if (a[i] > max2 && a[i] != max1)
                {
                    max2 = a[i];
                }
            }

            Console.WriteLine("Secomd Maximum number in array = " + max2);
        }
        /* static void Main(string[] args)
         {

             int[] a = { 65,44,75,32,10 };
             foreach (int a1 in a)
             {
                 Console.WriteLine(a1);
             }
             FindSecondHigh(a);

         }*/
    }
}