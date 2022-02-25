using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phuongtrinh
{
    class Bai2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập vào a: ");
            float a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a phải khác 0");
            }
            else
            {
                Console.WriteLine("\nNhập vào b: ");
                float b = Convert.ToInt32(Console.ReadLine());

                float x = -b / a;
                Console.WriteLine("\n{0}x + {1} = 0 \n\nVậy x = {2}", a, b, x);
            }
            Console.ReadKey();
        }
    }
}
