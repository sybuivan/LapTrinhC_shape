using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Bao : TaiLieu
    {
        private int ngayPhatHanh;

        public Bao(string id, string nxb, int number, int ngayPhatHanh) : base(id, nxb, number)
        {
            this.ngayPhatHanh = ngayPhatHanh;
        }

        public Bao()
        {

        }

        public int NgayPhatHanh{ get => ngayPhatHanh; set => ngayPhatHanh = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap Ngay Phat Hanh");
            ngayPhatHanh = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\nNgay Phat Hanh: {0}", ngayPhatHanh);
        }
    }
}
