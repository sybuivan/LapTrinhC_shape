using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_66
{
    class Program
    {
        static void HienMang(int[] arr_48, int n_48)
        {
            for (int i_48 = 0; i_48 < n_48; i_48++)
            {
                Console.Write(arr_48[i_48] + " ");
                //Console.WriteLine();
            }
        }

        static void SinhMang(int[] arr_48, int n_48)
        {
            Random rd = new Random();
            for (int i_48 = 0; i_48 < n_48; i_48++)
            {
                arr_48[i_48] = rd.Next(95, 100);

                Console.Write(" {0} ", arr_48[i_48]);
            }
        }


        static void Max_Min(int[] arr_48, int n_48)
        {
            int Max_48, Min_48;
            Max_48 = Min_48 = 0;

            for (int i_48 = 1; i_48 < n_48; i_48++)
            {
                if (arr_48[i_48] < arr_48[Min_48]) Min_48 = i_48;
                if (arr_48[i_48] > arr_48[Max_48]) Max_48 = i_48;
            }
            Console.Write("\nMax la: " + arr_48[Max_48] + " va " + "Min la: " + arr_48[Min_48]);

            int k_48;
            for (int i = k_48 = Max_48 + 1; i < n_48; ++i)
                if (arr_48[i] != arr_48[Max_48]) arr_48[k_48++] = arr_48[i];
            n_48 = k_48;

            Console.WriteLine("\n");
            HienMang(arr_48, n_48);

        }
        static void Main(string[] args)
        {

            Console.Write("Nhap so phan tu mang: ");
            int n_48 = int.Parse(Console.ReadLine());
            int[] arr_48 = new int[n_48];

            SinhMang(arr_48, n_48);

            Max_Min(arr_48, n_48);


            Console.ReadKey();
        }
    }
}
