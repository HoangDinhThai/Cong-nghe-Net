using System;

namespace Lession1
{
    class Bai3
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Nhap vao a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap vao b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap vao c : ");
            c = Convert.ToInt32(Console.ReadLine());

            float delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(delta)) / 2 * a));
                Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(delta)) / 2 * a));

            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b / 2 * a);
            }
            else if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
    }
}