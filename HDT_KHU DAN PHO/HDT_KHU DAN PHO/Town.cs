using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HDT_KHU_DAN_PHO
{
    class Town
    {
        private Family[] dshodan248 = new Family[10];
        private int sohodan248;

        public void InputKhuPho()
        {
            Console.WriteLine("Nhap so ho dan: ");
            sohodan248 = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= sohodan248; i++)
            {
                Console.WriteLine("Nhap so ho dan thu " + i);
                dshodan248[i] = new Family();
                dshodan248[i].InputHoDan();
            }
            Console.WriteLine("Thong tin tat ca ho dan: ");
            for (int i = 1; i <= sohodan248; i++)
            {
                Console.WriteLine("Ho dan thu " + i);
                dshodan248[i].Display();
            }
        }
    }
}
