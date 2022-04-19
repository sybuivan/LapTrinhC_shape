using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1_248, a2_248, b1_248, b2_248, c1_248, c2_248, dx_248, dy_248, d_248, x_248, y_248;
            Console.Write("Nhap a1: ");
            a1_248 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b1: ");
            b1_248 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c1: ");
            c1_248 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap a2: ");
            a2_248 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b2: ");
            b2_248 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c2: ");
            c2_248 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("He phuong trinh: {0}x + {1}y = {2}", a1_248, b1_248, c1_248);
            Console.WriteLine("                 {0}x + {1}y = {2}", a2_248, b2_248, c2_248);
            d_248 = (a1_248 * b2_248 - a2_248 * b1_248);
            dx_248 = (c1_248 * b2_248 - c2_248 * b1_248);
            dy_248 = (a1_248 * c2_248 - a2_248 * c1_248);

            if(d_248 == 0)
            {
                if((dx_248 + dy_248) == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                } else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            } else
            {
                x_248 = dx_248 / d_248;
                y_248 = dy_248 / d_248;
                Console.WriteLine("Phuong trinh co he nghiem: ({0}, {1})", x_248, y_248);
            }

            Console.ReadKey();
        }
    }
}
