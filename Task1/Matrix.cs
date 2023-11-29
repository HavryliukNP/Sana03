using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Matrix
    {
        public static double[] RandomMatrix(int N, int MinValue = -100, int MaxValue = 100, 
            int digitCount = 1)
        {
            double[] array = new double[N];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = Math.Round(random.Next(MinValue, MaxValue) + 
                    random.NextDouble(), digitCount);

            return array;
        }
        public static double SumOfNegativeElements(double[] array, int digitCount = 1)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0)
                    sum += array[i];
            return Math.Round(sum, digitCount);
        }
        public static double SearchMinElement(double[] array)
        {
            double minElement = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] < minElement)
                    minElement = array[i];
            return minElement;

        }
        public static int SearchIndexMaxElement(double[] array)
        {
            double maxElement = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > maxElement) 
                { 
                    maxElement = array[i];
                    index = i;
                }
            return index;
        }
        public static double MaxFabsElement(double[] array)
        {
            double MaxFabsElement = Math.Abs(array[0]);
            for (int i = 1; i < array.Length; i++)
                if (Math.Abs(array[i]) > MaxFabsElement)
                    MaxFabsElement = Math.Abs(array[i]);
            return MaxFabsElement;
        }
        public static int SumIndexPositiveElements(double[] array)
        {
            int SumIndexMaxElements = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0)
                    SumIndexMaxElements += i;
            return SumIndexMaxElements;
        }
        public static int SearchCountIntegers(double[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
                if ((array[i] * 10) % 10 == 0)
                    count++;
            return count;
        }
    }
}