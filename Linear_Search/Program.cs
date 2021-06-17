using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearSearch l = new LinearSearch();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            l.Reorder(a);
            Console.ReadKey();
        }
    }
}
