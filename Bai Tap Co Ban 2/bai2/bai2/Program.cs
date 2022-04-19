using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA_248, yA_248, xB_248, yB_248;
            Console.WriteLine("A(xA,yA)");
            xA_248 = Convert.ToDouble(Console.ReadLine());
            yA_248 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B(xB,yB)");
            xB_248 = Convert.ToDouble(Console.ReadLine());
            yB_248 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("do dai |AB| = "+ Math.Sqrt((xB_248 - xA_248) * (xB_248 - xA_248) + (yB_248 - yA_248) * (yB_248 - yA_248)).ToString("N4"));
            Console.ReadKey();
        }
    }
}
