using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_64
{

    class Program
    {
        static void Input_arr_48ay(int[] arr_48, int n_48)
        {
            for (int i_48 = 0; i_48 < n_48; i_48++)
            {
                Console.Write("arr_48[" + (i_48+1) + "] = ");
                arr_48[i_48] = int.Parse(Console.ReadLine());
            }
        }

        static void Output_arr_48ay(int[] arr_48, int n_48)
        {
            for (int i_48 = 0; i_48 < n_48; i_48++)
                Console.Write(arr_48[i_48] + " ");
        }

        static bool IsPowerOfTwo(ulong x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }

        static void Xoa_Phan_Tu(int[] arr_48, int n_48)
        {
            int i_48, c_48, x_48;
            Console.Write("\nNhap so bat ky de xoa: ");
            x_48 = int.Parse(Console.ReadLine());
            for (c_48 = i_48 = 0; i_48 < n_48; ++i_48)
            {
                if (arr_48[i_48] != x_48)
                    arr_48[c_48++] = arr_48[i_48];
            }
            n_48 = c_48;
            Console.Write("\nMang sau khi xoa: ");
            for (i_48 = 0; i_48 < n_48; ++i_48)
                Console.Write(" " + arr_48[i_48]);

        }

        static void Main(string[] args)
        {
            int n_48;
            do
            {
                Console.Write("Nhap so phan tu cho mang: ");
                n_48 = int.Parse(Console.ReadLine());
            }
            while (n_48 < 0);

            int[] arr_48 = new int[n_48];

            Input_arr_48ay(arr_48, n_48);
            Console.Write("Cac phan tu trong mang la: ");
            Output_arr_48ay(arr_48, n_48);

            int count_48 = 0;
            for (int i_48 = 0; i_48 < n_48; i_48++)
            {
                bool b = IsPowerOfTwo((ulong)arr_48[i_48]);
                if (b)
                    count_48 = count_48 + 1;
            }

            Console.Write(" Co {0} so luy thua cua 2", count_48);

            Xoa_Phan_Tu(arr_48, n_48);
            Console.ReadKey();
        }
    }
}
