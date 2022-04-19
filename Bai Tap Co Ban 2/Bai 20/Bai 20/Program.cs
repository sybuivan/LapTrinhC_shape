using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int kw_248;
            long money_248;
            Console.Write("Nhap so dien kw tieu thu: ");
            kw_248 = Convert.ToInt32(Console.ReadLine());

            money_248 = kw_248 * 500;
            if (kw_248 > 100)
                money_248 = money_248 + (kw_248 - 100) * 300;
            if (kw_248 > 250)
                money_248 = money_248 + (kw_248 - 250) * 200;
            if (kw_248 > 350)
                money_248 = money_248 + (kw_248 - 350) * 500;

            Console.WriteLine("so tien {0}", money_248.ToString("N"));

            Console.ReadKey();
        }
    }
}
