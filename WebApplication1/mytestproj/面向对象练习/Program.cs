using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("张三", 22, '男', 80, 90, 95);
            student1.SayHello();
            student1.ShowScore();

            Student student2 = new Student("小陈", 21, '女', 85, 90, 78);
            student2.SayHello();
            student2.ShowScore();

            Console.ReadKey();
        }
    }
}
