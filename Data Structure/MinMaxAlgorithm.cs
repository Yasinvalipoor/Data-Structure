using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    public class MinMaxAlgorithm
    {
        public static int min { get; set; }
        public static int max { get; set; }

        public static void MinMax(int[] array)
        {
            min = max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];

                if (array[i] > max)
                    max = array[i];
            }

            Console.WriteLine($"Min: {min} , Max: {max}");

        }
    }
}
