using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào số giờ, xuất ra số tương đương tính theo tuần,theo ngày và theo giờ
            long hour_248;
            Console.Write("Nhap so gio:");
            hour_248 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} tuan {1} ngay {2} gio", (hour_248 / (24 * 7)), (hour_248 % (24 * 7))/24, (hour_248 % (24 * 7)) % 24);

            Console.ReadKey();
        }
    }
}
