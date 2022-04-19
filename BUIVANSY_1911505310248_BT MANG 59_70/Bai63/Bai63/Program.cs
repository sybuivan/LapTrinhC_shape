using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai63
{
    class Program
    {
        static void Main(string[] args)
        {
            int enter_number_48, count_48= 0;
            do
            {
                Console.Write("Nhap n=");
                enter_number_48 = int.Parse(Console.ReadLine());

            } while (enter_number_48 < 2 || enter_number_48 % 2 != 0);

            int[] arrayNumber = new int[enter_number_48];

            //iRanDom sẽ nhận có giá trị ngẫu nhiên trong khoảng 1 đến 100:
            Random rd = new Random();
            for (int i = 0; i < enter_number_48; ++i)
            {
                arrayNumber[i] = rd.Next(-100, 100);
                Console.Write(" {0} ", arrayNumber[i]);
                if (arrayNumber[i] %4 ==0 && Math.Abs(arrayNumber[i]) % 10 == 6)
                {
                    count_48 += 1;
                }
            }
            Console.WriteLine("\nCo {0} so vua chia het cho 4 va tan cung 6", count_48);

            for(int i = 0; i<enter_number_48; i++)
            {
                if (arrayNumber[i] % 2 != 0)
                    arrayNumber[i] *= 2;
                Console.Write(" {0} ", arrayNumber[i]);
            }

            Console.ReadKey();
        }
    }
}
