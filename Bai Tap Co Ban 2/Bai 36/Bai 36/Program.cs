using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_248;
            int CheckSNT(int num_248)
            {
                if (num_248 < 2)
                    return 0;
                for (int i_248 = 2; i_248 <= Math.Sqrt(num_248); i_248++)
                {
                    if (num_248 % i_248 == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
            do
            {
                Console.Write("Nhap n:");
                n_248 = Convert.ToInt32(Console.ReadLine());
                if (n_248 < 0)
                    Console.WriteLine("Nhap lai so n");
            }
            while (n_248 < 0);

            int dem_248 = 0; // dem tong so nguyen to
            int index_248 = 2;   // tim so nguyen to bat dau tu so 2
            while (dem_248 < n_248)
            {
                if (CheckSNT(index_248) == 1)
                {
                    Console.Write("{0} ", index_248);
                    dem_248++;
                }
                index_248++;
            }

            Console.ReadKey();

        }
    }
}
