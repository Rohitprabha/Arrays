using System;

namespace Param_Arrays
{
    class Program
    {
        public static void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            UseParams(1, 2, 3, 4);
            UseParams(1, 2, 3);
            int[] intArray = { 5, 6, 7, 8, 9 };
            UseParams(intArray);
        }
    }
}
