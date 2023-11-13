using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] s = { '1', '2', '3' };

            string s1;

            s1 = new string(s);

            Console.WriteLine(s1);


            StringBuilder sb = new StringBuilder();
            //string str = null;

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i <100000; i++) {
                sb.Append(i);
            }

            sw.Stop();

            Console.WriteLine(sb.ToString());

            Console.WriteLine(sw);

            Console.ReadKey();
        }
    }
}
