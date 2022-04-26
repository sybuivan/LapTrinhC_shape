
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanh_26_4_BuiVanSY
{
    class ptb2_248
    {
        private double a_248, b_248, c248;

        public double A_248 { get => a_248; set => a_248 = value; }
        public double B_248 { get => b_248; set => b_248 = value; }
        public double C248 { get => c248; set => c248 = value; }

        public ptb2_248(double a_248, double b_248, double c248)
        {
            this.A_248 = a_248;
            this.B_248 = b_248;
            this.C248 = c248;
        }

        public ptb2_248()
        {
        }

        public double delta_248(double a_248, double b_248, double c_248)
        {
            return a_248 * b_248 - 4 * a_248 * c_248;
        }



    public void GiaiHPT(double a_248, double b_248, double c_248)
    {
        if (delta_248(a_248, b_248, c_248) > 0)
        {
            Console.WriteLine("Phuong trinh co hai nghiem : ");
            Console.WriteLine("X1 = {0}", ((-b_248 - Math.Sqrt(delta_248(a_248, b_248, c_248)) / 2 * a_248)));
            Console.WriteLine("X2 = {0}", ((-b_248 + Math.Sqrt(delta_248(a_248, b_248, c_248))) / 2 * a_248));

        }
        else if (delta_248(a_248, b_248, c_248) == 0)
        {
            Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
            Console.WriteLine("X1 = X2 {0}", -b_248 / 2 * c_248);
        }
        else if (delta_248(a_248, b_248, c_248) < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }
    }

}

    class Animal
    {
        public void eat_248()
        {
            Console.WriteLine("Animal is eat..");
        }

        public void makeSound_248()
        {
            Console.WriteLine("Animal is sound");
        }

        public virtual void run_248()
        {

        }

        public virtual void fly_248()
        {

        }

    }

    class Cat: Animal
    {
        public override void run_248()
        {
            Console.WriteLine("Cat Runn");
        }
    }

     class Bird: Animal
    {
        public override void fly_248()
        {
            Console.WriteLine("Cat Fly...");
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            double a_248, b_248, c_248;
            Console.WriteLine("Nhap vao a : ");
            a_248 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao b : ");
            b_248 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao c : ");
            c_248 = float.Parse(Console.ReadLine());
            ptb2_248 ptb2 = new ptb2_248();
            ptb2.GiaiHPT(a_248, b_248, c_248);


            Animal cat = new Cat();
            Animal bird = new Bird();

            cat.eat_248();

            bird.fly_248();
        }
    }
}
