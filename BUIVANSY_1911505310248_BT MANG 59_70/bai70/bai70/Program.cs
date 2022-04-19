using System;

namespace bai70
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

            int[] arrayNumber = new int[enter_number_48];

            //iRanDom sẽ nhận có giá trị ngẫu nhiên trong khoảng 1 đến 100:
            Random rd = new Random();
            int sumNumber = 0;
            for (int i = 0; i < enter_number_48; ++i)
            {
                arrayNumber[i] = rd.Next(-100, 100);
                Console.Write(" {0} ", arrayNumber[i]);
                if (arrayNumber[i] > 0)
                {
                    sumNumber += arrayNumber[i];
                }
            }
            for (int i = 0; i < enter_number_48 - 1; i++)
                for (int j = i; j < enter_number_48; j++)
                {
                    if (arrayNumber[j] % 2 == 0)
                    {
                        int t = arrayNumber[i];
                        arrayNumber[i] = arrayNumber[j];
                        arrayNumber[j] = t;
                        break;
                    }
                }

            Console.Write("\nMang sau khi sap xep: ");
            for (int i = 0; i < enter_number_48; i++)
                Console.Write("{0}  ", arrayNumber[i]);

            Console.ReadKey();
        }
    }
}
