using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пример_2
{

    internal class Program
    {

        static void Perim(int a, int b)
        {
            Console.WriteLine("Периметр прямоугольника = {0}", 2 * a + 2 * b);
        }
        static void Perim(int a, int b , int c)
        {
            Console.WriteLine("Периметр прямоугольника = {0}", a+b+c);
        }
        static void Perim(params int[] ar)
        {
            int p = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                p += ar[i];
            }
            Console.WriteLine("периметр {0} угольника = {1}", ar.Length, p);
        }
        static void Main(string[] args)
        {
            Perim(10, 20);
            Perim(3, 4, 5);
            Perim(2, 3, 4, 5, 6, 7, 9);
            Console.ReadKey();
        }
    }
}
