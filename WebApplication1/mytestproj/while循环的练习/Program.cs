using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环的练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //练习: 输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            //假设班级有10个人
            //循环体：将所有学员的成绩相加，得到一个总成绩
            //循环条件: 学员的人数

            int score;
            int i = 1;
            int sum = 0;
            bool flag = true;
            while (i <= 10)
            {

                Console.WriteLine("请输入学员的成绩");
                try
                {

                    score = Convert.ToInt32(Console.ReadLine());
                    sum += score;
                    i++;

                }
                catch
                {
                    Console.WriteLine("您输入的成绩有误，程序退出");
                    flag = false;
                    break;
                }
            }

            if (flag) { Console.WriteLine("该10名学员的总成绩为{0}，平均成绩为{1}", sum, sum / 10); }
            Console.ReadKey();
        }
    }
}
