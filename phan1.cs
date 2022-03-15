using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace phan1
{
    class kiemtra
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Nhap vao 10 phan tu cua mang: ");
            int[] arr = new int[100];
            for (int i = 16; i <= 25; i++)
            {
                Console.Write("\nPhan tu - {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.Write("\nCac phan tu chia het cho 3\n");
            for (int i = 16; i <= 25; i++)
            {

                if (arr[i] % 3 == 0)
                {
                    Console.Write("\nPhan tu - {0} chia het cho 3 la: ", i);
                    Console.WriteLine(arr[i]);
                }
            }

            Console.WriteLine("\nNhap vao phan tu x can kiem tra: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int dem = 0;

            for (int i = 16; i <= 25; i++)
            {
                if (arr[i] % n == 0)
                {
                    dem++;
                }
            }

            if (dem != 0)
            {
                Console.WriteLine("\nTrong phan tu da co phan nay roi !");
            }

            Console.Write("\nNhap vao phan tu y = ");

            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 16; i <= 25; i++)
            {
                if (arr[i] == a)
                {
                    count ++;
                }
            }
            Console.WriteLine("\nTrong mang, y xuat hien: " + count + " lan");
        }
    }
}
