using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 练习：让用户输入姓名、语文 数学 和英语成绩
            // 然后给用户显示：XX，你的总成绩为XX分，平均成绩为XX分
            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的语文成绩");
            string chineseScore = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩");
            string mathScore = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩");
            string englishScore= Console.ReadLine();

            double totalScore = Convert.ToDouble(chineseScore) + Convert.ToDouble(mathScore) + Convert.ToDouble(englishScore);

            double avgScore = (int)totalScore * 1.0 / 3;

            Console.WriteLine("{0}, 你的总成绩为{1}分，平均成绩为{2:0.00}分", name, totalScore, avgScore);
            Console.ReadKey();
        }
    }
}
