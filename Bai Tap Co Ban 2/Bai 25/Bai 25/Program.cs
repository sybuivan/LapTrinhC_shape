using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a_248, b_248;
            int USCLN_248(int a, int b)
            {
                if (b == 0) return a;
                return USCLN_248(b, a % b);
            }
            int BSCNN_248(int a, int b)
            {
                return (a * b) / USCLN_248(a, b);
            }
            do
            {
                Console.Write("Nhap so duong a=");
                a_248 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap so duong a=");
                b_248 = Convert.ToInt32(Console.ReadLine());

                if (a_248 < 0 && b_248 < 0)
                    Console.Write("Nhap lai 2 so a b");
            }
            while ((a_248 < 0) && (b_248 < 0));

            Console.WriteLine("Uoc so chung lon nhat la {0}", USCLN_248(a_248, b_248));
            Console.WriteLine("Boi chung nho nhat la {0}", BSCNN_248(a_248, b_248));

            Console.ReadKey();
        }
    }
}
