using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai59
{
    class Program
    {
        static void Main(string[] args)
        {
            int nam_48;
            string[] can_48 = new string[] { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi_48 = new string[] { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };
            Console.Write("Nhap nam:");
            nam_48 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nam {0} - {1} {2}", nam_48, can_48[nam_48 % 10], chi_48[nam_48 % 12]);
            Console.WriteLine("Nam {0} - {1} {2}", nam_48 + 60, can_48[nam_48 % 10], chi_48[nam_48 % 12]);

            Console.ReadKey();
        }
    }
}
