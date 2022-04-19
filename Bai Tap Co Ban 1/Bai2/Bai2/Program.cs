using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_248;
            Console.WriteLine("Nhap 1 so bat ky tu 1 den 9: ");
            num_248 = Int32.Parse(Console.ReadLine());
            switch (num_248)
            {
                case 0: Console.WriteLine("Không"); break;
                case 1: Console.WriteLine("Một"); break;
                case 2: Console.WriteLine("Hai"); break;
                case 3: Console.WriteLine("Ba"); break;
                case 4: Console.WriteLine("Bốn"); break;
                case 5: Console.WriteLine("Năm"); break;
                case 6: Console.WriteLine("Sáu"); break;
                case 7: Console.WriteLine("Bảy"); break;
                case 8: Console.WriteLine("Tám"); break;
                case 9: Console.WriteLine("Chín"); break;
                default:
                    Console.WriteLine("Nhap sai"); break;
            }

            Console.ReadKey();
        }
    }
}
