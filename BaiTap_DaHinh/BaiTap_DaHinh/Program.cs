using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_DaHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int hinhHoc_248;
            Console.WriteLine("2 - hinh tu giac");
            Console.WriteLine("3 - hinh binh hanh ");
            Console.WriteLine("4 - hinh chu nhat ");
            Console.WriteLine("5 - hinh vuong ");
            Console.WriteLine("1 - hinh tam giac");
            Console.WriteLine("Nhap hinh muon xem: ");
            Console.WriteLine("=========================================");
            hinhHoc_248 = int.Parse(Console.ReadLine());

            switch (hinhHoc_248)
            {
                case 1:
                    {
                        tamGiac tg_248 = new tamGiac();
                        tg_248.xuat();
                    }
                    break;
                case 2:
                    {
                        tuGiac tg_248 = new tuGiac();
                        tg_248.xuat();
                    }
                    break;
                case 3:
                    {
                        hinhBinhHanh hbh_248 = new hinhBinhHanh();
                        hbh_248.xuat();
                    }
                    break;
                case 4:
                    {
                        hinhChuNhat hcn_248 = new hinhChuNhat();
                        hcn_248.xuat();
                    }
                    break;
                case 5:
                    {
                        hinhVuong hv_248 = new hinhVuong();
                        hv_248.xuat();
                    }
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
