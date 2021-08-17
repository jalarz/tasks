using System;

namespace class_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(sum(arr));
        }
         static int sum(int[] arr)
        {
            int summ = 0;
           int average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                summ += arr[i];   
            }
            average = summ / arr.Length;

            return average;
        }
        
}
    }

