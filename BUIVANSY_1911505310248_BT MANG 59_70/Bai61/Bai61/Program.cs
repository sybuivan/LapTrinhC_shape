using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai61
{
    class Program
    {
        static void Main(string[] args)
        {
            int enter_number_48;
            do
            {
                Console.Write("Nhap n=");
                enter_number_48 = int.Parse(Console.ReadLine());

            } while (enter_number_48 < 2 || enter_number_48 % 2 != 0);

            int[] arrayNumber_48 = new int[enter_number_48];

            //iRanDom sẽ nhận có giá trị ngẫu nhiên trong khoảng 1 đến 100:
            Random rd = new Random();
            int sumNumber = 0;
            for (int i = 0; i < enter_number_48; ++i)
            {
                arrayNumber_48[i] = rd.Next(-100, 100);
                Console.Write(" {0} ", arrayNumber_48[i]);
                if (arrayNumber_48[i] > 0)
                {
                    sumNumber += arrayNumber_48[i];
                }
            }

            Console.WriteLine("Tong so nguyen duong co trong day la: {0}", sumNumber);

            int numberDelete_48;
            Console.Write("Nhap so p: ");
            numberDelete_48 = int.Parse(Console.ReadLine());
            for (int i = numberDelete_48 + 1; i < enter_number_48; ++i)
                arrayNumber_48[i - 1] = arrayNumber_48[i];
            enter_number_48--;

            for (int i = 0; i < enter_number_48; ++i)
                Console.Write(" {0} ", arrayNumber_48[i]);

            Console.ReadKey();
        }
    }
}
