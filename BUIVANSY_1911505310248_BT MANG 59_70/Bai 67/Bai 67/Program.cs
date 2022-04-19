using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_67
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
                arr_48[i_48] = rd.Next(-100, 100);

                Console.Write(" {0} ", arr_48[i_48]);
            }
        }
        static void Sap_Xep(int[] arr_48, int n_48)
        {
            int i_48, j_48, t_48;
            for (i_48 = 0; i_48 < n_48 - 1; ++i_48)
            {
                for (j_48 = i_48 + 1; j_48 < n_48; ++j_48)
                {
                    if ((arr_48[i_48] % 2 == 0 && arr_48[j_48] % 2 == 0 && arr_48[i_48] > arr_48[j_48]) ||
                        (arr_48[i_48] % 2 != 0 && arr_48[j_48] % 2 != 0 && arr_48[i_48] < arr_48[j_48]))
                    {
                        t_48 = arr_48[i_48];
                        arr_48[i_48] = arr_48[j_48];
                        arr_48[j_48] = t_48;
                    }
                }
            }

            Console.Write("\nMang sau khi sap xep: ");
            HienMang(arr_48, n_48);
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu mang: ");
            int n_48 = int.Parse(Console.ReadLine());
            int[] arr_48 = new int[n_48];

            SinhMang(arr_48, n_48);

            Sap_Xep(arr_48, n_48);
            Console.ReadKey();
        }
    }
}
