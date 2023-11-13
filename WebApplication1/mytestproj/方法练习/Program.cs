using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //79. 用方法实现：有一个字符串数组：
            // {"马龙"，"迈克尔乔丹"，"雷吉米勒"，"提姆邓肯"，"科比布莱恩特"}

            string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "提姆邓肯", "科比布莱恩特" };
            string max = GetLongest(names);
            Console.WriteLine(max);




            Console.ReadKey();
        }

        public static string GetLongest(string[] s)
        {
            string max = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                max = s[i].Length > max.Length ? s[i] : max;
            }

            return max;
        }
    }
}
