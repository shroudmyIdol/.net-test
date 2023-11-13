using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{

    public enum QQState
    {
        Online,
        Offline,
        Leave,
        Busy
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //为什么有枚举这个东西
            //XX大学管理系统
            //姓名 性别 年龄 年纪


            //Gender gender = Gender.男;

            //枚举练习
            //提示用户选择一个在线的状态，我们接收并将用户的输入转换成枚举类型
            //打印在控制台

            Console.WriteLine("请选择您qq的在线状态 1--Online 2--Offline 3--Leave 4--Busy");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的状态是{0}", s1);
                    break;
                case "2":
                    QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的状态是{0}", s2);
                    break;
                case "3":
                    QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的状态是{0}", s3);
                    break;
                case "4":
                    QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的状态是{0}", s4);
                    break;
                default:
                    Console.WriteLine("您输入的状态有误，程序退出！！！！");
                    break;
            }

            Console.ReadKey();

        }
    }
}
