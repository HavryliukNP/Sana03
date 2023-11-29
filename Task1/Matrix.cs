using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Matrix
    {
        public static int[] RandomMatrix(int N, int MinValue = -100, int MaxValue = 100)
        {
            int[] array = new int[N];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(MinValue, MaxValue);
            }

            return array;
        }
        public static int SumOfNegativeElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    sum += array[i];
            }
            return sum;
        }
    }
}
