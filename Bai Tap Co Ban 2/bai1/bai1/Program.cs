using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi_248 = 3.141593f;
            double S_248,V_248;
            Console.Write("Nhap dien tich S = ");
            S_248 = Convert.ToDouble(Console.ReadLine());
            V_248 = (4 * pi_248 * Math.Pow(Math.Sqrt(S_248 / (4 * pi_248)), 3)) / 3 ;
            Console.Write("The tich V = {0}", V_248.ToString("N4"));
            Console.ReadKey();
        }
    }
}
