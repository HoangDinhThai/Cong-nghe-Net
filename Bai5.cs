using System;

namespace minmax
{
    class Bai5
    {
        static void Main(String[] args)
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

                int max = numbers[0];
                int min = numbers[0];
                for (int i = 1; i < n; i++)
                {
                    if (max < numbers[i])
                    {
                        max = numbers[i];
                    }
                    if (min > numbers[i])
                    {
                        min = numbers[i];
                    }
                }

                // Hien thi mang:

                Console.WriteLine("Cac phan tu trong mang: \n");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(numbers[i] + " ");
                }

                Console.WriteLine("\nGia tri lon nhat trong mang: " + max);
                Console.WriteLine("\nGia tri nho nhat trong mang: " + min);
            }
            else
            {
                Console.WriteLine("Nhap so nguyen n > 0");
            }

        }
    }
}

