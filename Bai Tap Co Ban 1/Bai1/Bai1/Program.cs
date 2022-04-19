using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_248;
            Console.Write("Nhap mot so:");
            num_248 = Convert.ToInt32(Console.ReadLine());

            if(num_248 > 0)
            {
                Console.WriteLine("So {0} la so nguyen duong", num_248);
            } else
            {
                Console.WriteLine("So {0} la so nguyen am", num_248);
            }
            
            Console.ReadKey();
        }
    }
}
