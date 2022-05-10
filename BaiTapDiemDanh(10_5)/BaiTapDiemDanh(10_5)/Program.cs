using System;

namespace BaiTapDiemDanh_10_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so ptu cua mang: ");
            int n_248 = int.Parse(Console.ReadLine());
            int[] a_248 = new int[100];
            nhapSoNguyen(a_248, n_248);
            xuatSoNguyen(a_248, n_248);

            Console.ReadKey();
        }
        static void nhapSoNguyen(int[] a_248, int n_248)
        {
            for (int i = 0; i < n_248; i++)
            {
                Console.Write("a[" + i + "]=");
                a_248[i] = int.Parse(Console.ReadLine());
            }
        }

        static void xuatSoNguyen(int[] a_248, int n_248)
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < n_248; i++)
                Console.Write(a_248[i] + " ");
        }


    }
}
