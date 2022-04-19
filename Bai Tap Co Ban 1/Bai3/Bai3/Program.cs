using System;

namespace Bai3
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
                Console.WriteLine("3 canh la tam giac");
            }
            else
            {
                Console.WriteLine("3 canh khong phai la tam giac");
            }
        }
    }
}
