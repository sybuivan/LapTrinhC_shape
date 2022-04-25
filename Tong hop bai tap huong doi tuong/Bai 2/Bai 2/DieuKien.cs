using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class DieuKien
    {
        public static int choose()
        {
            int a;
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    return a;
                }
                catch (System.Exception)
                {

                    Console.WriteLine("Nhap lai!!");
                }
            }
        }
    }
}
