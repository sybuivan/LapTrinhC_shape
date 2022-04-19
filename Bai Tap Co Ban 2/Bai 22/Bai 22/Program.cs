using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_248, i_248;
            long sum_248 = 0;
            do
            {
                Console.WriteLine("Nhap vào so nguyen n lon hon 0: ");
                Console.Write("Nhap so: ");
                n_248 = Convert.ToInt32(Console.ReadLine());
                if (n_248 <= 0)
                {
                    Console.Write("So n phai lon hơn 0, vui long nhap lai ");
                }
            } while (n_248 <= 0);

            Console.Write("Cac uoc cua {0} la: ", n_248);
            for (i_248 = 1; i_248 <= n_248; i_248++)
            {
                if (n_248 % i_248 == 0)
                {
                    Console.Write("{0}\t", i_248);
                    sum_248 = sum_248 + i_248;
                }
            }
            Console.Write("\nTong uoc cua so {0} là: {1}", n_248, sum_248);

            Console.ReadKey();
        }
    }
}
