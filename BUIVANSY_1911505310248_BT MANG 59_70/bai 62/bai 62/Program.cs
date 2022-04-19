using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_62
{
    class Program
    {
        static int GCD(int Number1_48, int Number2_48)
        {
            if (Number2_48 == 0) return Number1_48;
            return GCD(Number2_48, Number1_48 % Number2_48);
        }

        static void Prime_Number_Pair(int[] arr_48, int n_48)
        {
            int i1, j1;
            Console.Write("\nCac cap nguyen to cung nhau:\n");
            for (i1 = 0; i1 < n_48; ++i1)
                for (j1 = i1 + 1; j1 < n_48; ++j1)
                    if (GCD(arr_48[i1], arr_48[j1]) == 1)
                        Console.Write("({0}, {1})\n", arr_48[i1], arr_48[j1]);

        }

        static void Main(string[] args)
        {
            int enter_number_48;
            do
            {
                Console.Write("Nhap n=");
                enter_number_48 = int.Parse(Console.ReadLine());

            } while (enter_number_48 < 2 || enter_number_48 % 2 != 0);

            int[] arrayNumber_48 = new int[enter_number_48];

            //iRanDom sẽ nhận có giá trị ngẫu nhiên trong khoảng 10 đến 20:
            Random rd = new Random();
            int sumNumberEven = 0, sumNumberOdd = 0;
            for (int i = 0; i < enter_number_48; ++i)
            {
                arrayNumber_48[i] = rd.Next(10, 20);


                Console.Write(" {0} ", arrayNumber_48[i]);
                if (arrayNumber_48[i]%2 == 0)
                {
                    sumNumberEven += arrayNumber_48[i];
                } else
                {
                    sumNumberOdd += arrayNumber_48[i];
                }
            }

            if(sumNumberEven == sumNumberOdd)
                Console.WriteLine("tong chan {0} bang tong le {1}", sumNumberEven, sumNumberOdd);
            else
                Console.WriteLine("tong chan {0} khong bang tong le {1}", sumNumberEven, sumNumberOdd);


            Prime_Number_Pair(arrayNumber_48, enter_number_48);
            Console.ReadKey();
        }
    }
}
