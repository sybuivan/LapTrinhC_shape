using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class TaiLieu
    {
        protected string id;
        protected string nxb;
        protected int number;

        public TaiLieu(string id, string nxb, int number)
        {
            this.id = id;
            this.nxb = nxb;
            this.number = number;
        }

        public TaiLieu()
        {

        }
        public string Id{get => id; set => id = value;}
        public string Nxs { get => nxb; set => nxb = value; }
        public int Number { get => number; set => number = value; }

        public virtual void Nhap()
        {
            Console.WriteLine("=====NHap du lieu tai lieu=====");
            Console.WriteLine("Nhap Ma Tai Lieu : ");
            id = Console.ReadLine();
            Console.WriteLine("Nhap Nha Xuat Ban: ");
            nxb = Console.ReadLine();
            Console.WriteLine("Nhap So phat hanh  ");
            number = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.Write("Ma Tai Lieu: {0} \n Nha Xuat Ban: {1} \n So Phat Hanh: {2}", id, nxb, number);
        }

    }
}
