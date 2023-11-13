using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接受用户输入
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 练习：问用户的姓名、年龄和性别后，在控制台输出"尊敬的XX先生/小姐，您目前已经XX岁了~"

            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的年龄");
            string age = Console.ReadLine();
            Console.WriteLine("请输入你的性别");
            string gender = Console.ReadLine();
            string genderStr = gender == "男" ? "先生" : "小姐";
            Console.WriteLine("尊敬的{0}{1}, 您目前已经{2}岁了~", name, genderStr, age);
            Console.ReadKey();
        }
    }
}
