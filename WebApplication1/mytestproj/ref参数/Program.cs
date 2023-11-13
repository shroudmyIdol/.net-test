using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref参数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            Zhangxin(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();
        }

        public static void Zhangxin(ref double s) {

            s += 500;
        }
    }
}
