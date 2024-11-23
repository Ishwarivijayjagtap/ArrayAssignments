using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignments
{
    public class EquivalentSum
    {
        public static void SumEquiNum(int[] a, int num)
        {
            bool isfound = false;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == num)
                    {
                        Console.WriteLine($"Pair of elements is found = {a[i]} ,{a[j]}");
                        isfound = true;
                    }

                }

            }

            if (!isfound)
            {
                Console.WriteLine("No pairs found ");
            }
        }

        /* static void Main(string[] args)
         {

             int[] a = { 51,47,20,34,66};
             int givenNum = 54;

             SumEquiNum(a, givenNum);
         }*/

    }
}