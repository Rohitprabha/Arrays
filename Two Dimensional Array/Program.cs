using System;

namespace TwoDimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numArray = new int[3, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 } };
            //int val = numArray[2, 3];           //Accessing individual Elements
            //Console.WriteLine(val);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <4 ; j++)
                {
                    Console.WriteLine("numArray[{0},{1}] = {2}", i, j, numArray[i, j]);
                }
            }
        }
    }
}
