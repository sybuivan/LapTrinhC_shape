using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class QuanLySach
    {
        private List<TaiLieu> taiLieu = new List<TaiLieu>();

        public void addTaiLieu()
        {
            int num;
            do
            {
                Console.WriteLine("===Chon vi tri muon them===");
                Console.WriteLine("1.Bao");
                Console.WriteLine("2.Sach");
                Console.WriteLine("3.Tap chi");
                Console.WriteLine("4.Thoat");
                int d = DieuKien.choose();
                num = d;
                switch (d)
                {
                    case 1:
                        Bao b = new Bao();
                        b.Nhap();
                        taiLieu.Add(b);
                        break;
                    case 2:
                        Sach s = new Sach();
                        s.Nhap();
                        taiLieu.Add(s);
                        break;
                    case 3:
                        TapChi tc = new TapChi();
                        tc.Nhap();
                        taiLieu.Add(tc);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!");
                        break;
                }
            } while (num != 4);
        }

        public void deleteDocument()
        {
            Console.WriteLine("Nhap ma tai lieu can xoa: ");
            string matl = Console.ReadLine();
            for (int i = 0; i < taiLieu.Count; i++)
            {
                if (taiLieu[i].Id.Equals(matl))
                {
                    taiLieu.RemoveAt(i);
                }
            }
        }

        public void View()
        {
            if (taiLieu.Count == 0)
            {
                Console.WriteLine("Khong co tai lieu trong danh sach , vui vong them tai lieu");
            }
            for (int i = 0; i < taiLieu.Count; i++)
            {
                taiLieu[i].Xuat();
            }
        }

        public void search()
        {
            Console.WriteLine("Nhap ma tai lieu can tim: ");
            string matl = Console.ReadLine();
            for (int i = 0; i < taiLieu.Count; i++)
            {
                if (taiLieu[i].Id.Equals(matl))
                {
                    taiLieu[i].Xuat();
                }
            }
        }

        public void Menu()
        {
            int choose;
            do
            {
                Console.WriteLine("1. Them moi tai lieu");
                Console.WriteLine("2. Xoa tai lieu theo ma");
                Console.WriteLine("3. Hien thi thong tin tai lieu");
                Console.WriteLine("4. Tim kiem tai lieu theo loai: Bao, Tap chi, Sach");
                Console.WriteLine("5. Thoat");
                choose = DieuKien.choose();
                switch (choose)
                {
                    case 1:
                        addTaiLieu();
                        break;
                    case 2:
                        deleteDocument();
                        break;
                    case 3:
                        View();
                        break;
                    case 4:
                        search();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!!");
                        break;
                }
            } while (choose != 5);
        }
    }
}
