using System;
using System.Collections.Generic;
using System.Text;

namespace HDT_KHU_DAN_PHO
{
    class Family: people
    {
        private int sotv248;
        private int sonha248;
        private people[] thanhvien248 = new people[10];

        public int Sotv248 { get => sotv248; set => sotv248 = value; }
        public int Sonha248 { get => sonha248; set => sonha248 = value; }
        internal people[] Thanhvien248 { get => thanhvien248; set => thanhvien248 = value; }

        public Family()
        {

        }

        public Family(int sotv248, int sonha248, people[] thanhvien248)
        {
            this.sotv248 = sotv248;
            this.sonha248 = sonha248;
            this.thanhvien248 = thanhvien248;
        }

        public void InputHoDan()
        {
            Console.WriteLine("Nhap so thanh vien: ");
            sotv248 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nha: ");
            sonha248 = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= Sotv248; i++)
            {
                Console.WriteLine("Nhap so thanh vien thu " + i);
                thanhvien248[i] = new people();
                thanhvien248[i].InputNguoi();
            }
        }
        public void Display()
        {
            Console.WriteLine("So thanh vien: {0}, So nha: {1}", sotv248, sonha248);
            for (int i = 1; i <= sotv248; i++)
            {
                Console.WriteLine("Thanh vien thu " + i);
                thanhvien248[i].Display();
            }
        }
    }
}
