using System;
using System.Collections.Generic;
using System.Text;

namespace HDT_KHU_DAN_PHO
{
    class people
    {

        private string hoten248;
        private DateTime tuoi248;
        private string nghenghiep248;
        private int cmnd248;

        public people()
        {
        }

        public people(string hoten248, DateTime tuoi248, string nghenghiep248, int cmnd248)
        {
            this.Hoten248 = hoten248;
            this.Tuoi248 = tuoi248;
            this.Nghenghiep248 = nghenghiep248;
            this.Cmnd248 = cmnd248;
        }

        public string Hoten248 { get => hoten248; set => hoten248 = value; }
        public DateTime Tuoi248 { get => tuoi248; set => tuoi248 = value; }
        public string Nghenghiep248 { get => nghenghiep248; set => nghenghiep248 = value; }
        public int Cmnd248 { get => cmnd248; set => cmnd248 = value; }

        public virtual void InputNguoi()
        {
            Console.WriteLine("Nhap Ho va Ten : ");
            hoten248 = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            tuoi248 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nghe nghiep:  ");
            nghenghiep248 = Console.ReadLine();
            Console.WriteLine("Nhap so cmnd: ");
            cmnd248 = Int32.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Ho va Ten: {0} , Ngay sinh : {1} , Nghe nghiep: {2} , CMND: {3}", hoten248, tuoi248, nghenghiep248, cmnd248);
            Console.WriteLine("----------------------------------------------------------------------------------------------");
        }
    }
}
