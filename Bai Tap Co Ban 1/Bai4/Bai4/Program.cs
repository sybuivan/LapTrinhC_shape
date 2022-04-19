using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a248, b248, c248;
            Console.Write("Nhap 3 canh a,b,c: ");
            a248 = Double.Parse(Console.ReadLine());
            b248 = Double.Parse(Console.ReadLine());
            c248 = Double.Parse(Console.ReadLine());

            if (a248 > 0 && b248 > 0 && c248 > 0 && a248 + b248 > c248 && b248 + c248 > a248 && c248 + a248 > b248)
            {
                if (a248 * a248 == b248 * b248 + c248 * c248 || b248 * b248 == a248 * a248 + c248 * c248 || c248 * c248 == a248 * a248 + b248 * b248)
                {
                    Console.WriteLine("La tam giac vuong");
                }
                else
                {
                    Console.WriteLine("Khong phai tam giac vuong");
                }
            }
            else
            {
                Console.WriteLine("Khong phai la tam giac");
            }

            Console.ReadKey();
        }
    }
}
