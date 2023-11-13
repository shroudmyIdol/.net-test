using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输入一个txt文件
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "外面的天阴沉沉的\n貌似要下大雨的节奏";

            System.IO.File.WriteAllText(@"C:\Users\hanj\Desktop\111.txt", str);

            Console.WriteLine("写入成功~！！");
            Console.ReadKey();
        }
    }
}
