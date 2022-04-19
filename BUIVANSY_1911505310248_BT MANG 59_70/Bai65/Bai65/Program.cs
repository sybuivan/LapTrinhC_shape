using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai65
{
    class Program
    {
        static void Main(string[] args)
        {
            int enter_number_48, count_48 = 0;
            do
            {
                Console.Write("Nhap n=");
                enter_number_48 = int.Parse(Console.ReadLine());

            } while (enter_number_48 < 2);

            int[] arrayNumber_48 = new int[enter_number_48];

            Console.WriteLine("Nhap {0} phan tu:", enter_number_48);
            for(int i = 0; i< enter_number_48; i++)
            {
                Console.Write("so {0}: ", i+1);
                arrayNumber_48[i] = int.Parse(Console.ReadLine());
            }
            int arg_48 = 0;
            for (int i = 0; i < enter_number_48; i++)
            {
                Console.Write(" {0} ", arrayNumber_48[i]);
                if (arrayNumber_48[i] < 0 && arrayNumber_48[i] % 2 != 0)
                {
                    count_48  = count_48 + 1;
                    arg_48 = arg_48 + arrayNumber_48[i];
                }
            }

            Console.Write("\nTong trung binh cong so nguyen am la: {0}", (float)arg_48/count_48);

            Console.ReadKey();
        }
    }
}
