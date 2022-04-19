using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_47
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_248, sum_248 = 0;
            Console.Write("Nhap n: ");

            num_248 = Convert.ToInt32(Console.ReadLine());
            if(num_248 % 2 ==0)
            {
                for (int i_248 = 1; i_248 <= num_248; i_248++)
                    sum_248 += 2 * i_248;
            } else if(num_248 % 2 !=0)
            {
                for (int i_248 = 1; i_248 <= num_248; i_248++)
                    sum_248 += i_248;
            }

            Console.WriteLine("Tong s = {0}", sum_248);

            Console.ReadKey();
        }
    }
}
