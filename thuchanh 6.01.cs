using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Program
{
    class baitap
    {
        static void Main(String[] args)
        {
            //bai1();
            //bai2();
            //bai3();
        }

        static void bai1()
        {
            Console.Write("Nhap vao a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao b = ");
            int b = Convert.ToInt32(Console.ReadLine());
        }

        static void bai2()
        {
            Console.Write("Nhap vao n = ");
            double n = double.Parse(Console.ReadLine());
            double S = 0;
            for (int i = 1; i <= n; i++)
                S += 1 / (double)i;
            Console.Write("S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n = " + S);

        }

        static void bai3()
        {
            Console.Write("Nhap vao so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + (i + 1) + "] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Cac phan tu am cua mang la: ");
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    Console.Write("a[" + (i + 1) + "] = " + a[i] + " ");
                }
            }

            Console.WriteLine("\nCac phan tu le cua mang la: ");
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write("a[" + (i + 1) + "] = " + a[i] + " ");
                }
            }
        }
    }
}