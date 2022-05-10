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

            Console.WriteLine("So lon nhat: {0}", Max(a_248, n_248));
            Console.Write("So Nho nhat: {0}", Min(a_248, n_248));
            Console.WriteLine("Sap xep giam dan:");
            Sapxepgiamdan(a_248, n_248);
            xuatSoNguyen(a_248, n_248);

            Console.WriteLine("Sap xep tang dan: ");
            Sapxeptangdan(a_248,n_248);
            xuatSoNguyen(a_248, n_248);

            Console.Write("So luot xuat hien phan tu nhieu nhat: {0}", countElement(a_248, n_248));
            Console.ReadKey();
        }
        static void nhapSoNguyen(int[] a_248, int n_248)
        {
            for (int i = 1; i <= n_248; i++)
            {
                Console.Write("a[" + i + "]=");
                a_248[i] = int.Parse(Console.ReadLine());
            }
        }

        static int Max(int[] arr_248, int n)
        {
            int Max_248 = arr_248[1];
            for (int i = 1; i <= n; i++)
            {
                if (Max_248 < arr_248[i])
                    Max_248 = arr_248[i];
            }
            return Max_248;
        }

        static int Min(int[] arr_248, int n_248)
        {
            int min_248 = arr_248[1];
            for (int i = 1; i <= n_248; i++)
            {
                if (arr_248[i] < min_248)
                    min_248 = arr_248[i];
            }
            return min_248;
        }

        static int countElement(int[] a_248, int n_248)
        {
            int max_248 = 0;
            int dem_248 = 1;
            for (int i = 1; i <= n_248; i++)
            {
                if (a_248[i] == a_248[i + 1])
                {
                    dem_248++;
                    if (dem_248 > max_248)
                    {
                        max_248 = dem_248;
                    }

                }
                else
                {

                    dem_248 = 1;
                }
            }
            return max_248;
        }

        static void Sapxepgiamdan(int[] a_248, int n)
        {
            int i, j, tmp;
            for (i = 1; i <= n; i++)
            {
                for (j = i + 1; j <= n; j++)
                {
                    if (a_248[i] < a_248[j])
                    {
                        tmp = a_248[i];
                        a_248[i] = a_248[j];
                        a_248[j] = tmp;
                    }
                }
            }
        }

        static void Sapxeptangdan(int[] a_248, int n)
        {
            int i, j, tmp;
            for (i = 1; i <= n; i++)
            {
                for (j = i + 1; j <= n; j++)
                {
                    if (a_248[i] > a_248[j])
                    {
                        tmp = a_248[i];
                        a_248[i] = a_248[j];
                        a_248[j] = tmp;
                    }
                }
            }
        }
        static void xuatSoNguyen(int[] a_248, int n_248)
        {
            Console.Write("Hien thi mang:");
            for (int i = 1; i <= n_248; i++)
                Console.Write(a_248[i] + " ");
        }


    }
}
