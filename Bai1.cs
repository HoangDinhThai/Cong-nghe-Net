using System;

namespace tamgiac
{
    class Bai1

    {
        static void Main(string[] args)
        {
            Console.Write("Nhap canh a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap canh b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap canh c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b < c || a + c < b || b + c < a)
            {
                //La tam giac
                Console.WriteLine("Day khong phai la tam giac ");
            }
            else if (a == b || a == c || b == c) // 2 canh bat ky bang nhau
            {
                // Tam giac can
                Console.WriteLine("Day la tam giac can");
            }
            else
            {
                // Khong phai tam giac
                Console.WriteLine("La tam giac");
            }
            Console.ReadKey();

        }
    }
}