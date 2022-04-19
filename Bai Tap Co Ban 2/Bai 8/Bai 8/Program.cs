using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a_248, b_248, c_248, x1_248, x2_248, delta_248;
            Console.WriteLine("Giai phuong trinh bac 2: ax^2 + bx + c = 0");
            Console.Write("Nhap a = ");
            a_248 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b = ");
            b_248 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c = ");
            c_248 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Phuong trinh {0}x^2 + {1}x + {2}", a_248, b_248, c_248);
            if(a_248 == 0)
            {
                if(b_248 == 0)
                {
                    if(c_248 == 0)
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem");
                } else
                {
                    x1_248 = -c_248 / b_248;
                    Console.WriteLine("Phuong trinh co nghiem x = {0}", x1_248);
                }
            } else
            {
                delta_248 = b_248 * b_248 - 4 * a_248 * c_248;
                if(delta_248 > 0)
                {
                    x1_248 = (-b_248 + Math.Sqrt(delta_248))/ (2 * a_248);
                    x2_248 = (-b_248 - Math.Sqrt(delta_248)) / (2 * a_248);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = {0}  x2 ={1}", x1_248, x2_248);
                } else if(delta_248 < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                } else
                {
                    x1_248 = -b_248 / 2 * a_248;
                    Console.WriteLine("Phuong trinh co 1 nghiem x1 = x2 = {0}", x1_248);
                }
            }
            Console.ReadKey();
        }
    }
}
