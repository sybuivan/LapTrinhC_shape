using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Sach : TaiLieu
    {
        private string tacGia;
        private int soTrang;

        public Sach(string id, string nxb, int number, string tacGia, int soTrang):base(id,nxb,number)
        {
            this.tacGia = tacGia;
            this.soTrang = soTrang;
        }

        public Sach()
        {

        }


        public String TacGia { get => tacGia; set => tacGia = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap tac gia");
            tacGia = Console.ReadLine();
            Console.WriteLine("Nhap so trang");
            soTrang = int.Parse(Console.ReadLine());

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Tac gia {0}", tacGia);
            Console.WriteLine("So trang {1}", soTrang);
        }
    }
}
