using System;
using System.Linq;

namespace Array_s
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ram", "Dev", "Mahi", "randy", "Ajay" };
            int[] myNumbers = { 5, 1, 8, 9 };

            //Console.WriteLine(names[0]);
            //names[0] = "Opel";                  //Change an Array Element
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names.Length);
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
            Array.Sort(names);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(myNumbers.Max());
            Console.WriteLine(myNumbers.Min());
            Console.WriteLine(myNumbers.Sum());
        }
    }
}
