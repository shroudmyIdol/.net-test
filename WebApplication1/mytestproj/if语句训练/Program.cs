using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if语句训练
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //练习1. 让用户输入年龄，如果用户输入的年龄大于23，则给用户显示你到了结婚的年龄了
            //Console.WriteLine("请输入你的年龄!");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age > 23) {
            //    Console.WriteLine("您已经到了结婚的年龄了~");
            //}
            //Console.ReadKey();

            //练习2. 让用户输入用户名和密码，如果用户为admin，密码为mypass, 则提示登录成功
            Console.WriteLine("请输入用户名");
            string account = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();
            if (account == "admin" && password == "mypass")
            {
                Console.WriteLine("登录成功！");
            }
            else {
                Console.WriteLine("登录失败！");
            }

            Console.ReadKey();

        }
    }
}
