using System;

namespace nhapgiatri
{
    class Bai4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap phan tu thu " + i);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Hien thi mang:

                Console.WriteLine("Cac phan tu trong mang la: ");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}