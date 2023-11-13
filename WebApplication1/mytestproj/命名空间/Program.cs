using class练习;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person zSan = new Person();

            zSan.Name = "张三";

            Console.WriteLine(zSan.Name);

            Console.ReadKey();
        }
    }
}
