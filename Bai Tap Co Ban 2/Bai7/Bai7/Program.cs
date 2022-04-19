using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a_248, b_248, x_248;
            Console.WriteLine("Giai phuong trinh ax+b=0");
            Console.Write("Nhap a= ");
            a_248 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b= ");
            b_248 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}x + {1} = 0", a_248, b_248);

            if(a_248 == 0)
            {
                if (b_248 == 0)
                    Console.WriteLine("Phuong trinh vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                x_248 = -b_248 / a_248;
                Console.WriteLine("Phuong trinh co nghiem x = {0}", x_248);
            }

            Console.ReadKey();
        }
    }
}
