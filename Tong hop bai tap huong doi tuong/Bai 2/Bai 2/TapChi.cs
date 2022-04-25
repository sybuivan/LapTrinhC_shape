using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class TapChi: TaiLieu
    {
        private int soPhatHanh;
        private int thangPhatHanh;

        public TapChi(string id, string nxb, int number, int soPhatHanh, int thangPhatHanh):base(id, nxb, number)
        {
            this.soPhatHanh = soPhatHanh;
            this.thangPhatHanh = thangPhatHanh;
        }

        public TapChi() { }



        public int SoPhatHanh { get => soPhatHanh; set => soPhatHanh = value; }
        public int ThangPhatHanh { get => soPhatHanh; set => thangPhatHanh = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap so phat hanh");
            soPhatHanh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang phat hanh");
            thangPhatHanh = int.Parse(Console.ReadLine());
        }


        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So phat hanh: {0} \n Thang phat hanh: {1}", soPhatHanh, thangPhatHanh);
        }
    }
}
