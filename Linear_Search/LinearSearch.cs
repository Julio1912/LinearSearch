using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linear_Search
{
    class LinearSearch
    {
        public LinearSearch(){}
        public void Reorder(int [] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            for (int i = 0; i < a.Length/2;i++ ) {
                int temp = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = temp;
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < a.Length; i++) {
                Console.Write(a[i]);
            }
        }
        public int[,] Matrixmultiplication(int[,] a, int[,] b) {
            int[,] c=new int[a.GetLength(0),a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++) {
                for (int j = 0; j < a.GetLength(0); j++) {
                    c[i, j] = 0;
                    for (int k = 0; k < a.GetLength(0); k++)
                        c[i, j] += a[i, k] * b[k, j];
                }
            }
            return c;
        }
    }
}
