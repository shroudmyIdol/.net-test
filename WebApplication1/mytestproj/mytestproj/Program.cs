using System;

namespace mytestproj
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 这些代码没有用，但是我想保留
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            //Console.WriteLine("随便写点东西输出一下看看");
            #endregion


            int num = 100;
            double a = 0.1;
            decimal b = 0.11m;
            float e = 3.24f;
            string c = "字符串123";
            char d = 'a';

            string name = "卡卡西";
            string address = "火影村";
            int age = 30;
            string email = "kakaxi@qq.com";
            decimal salary = 2000m;

            //Console.WriteLine("我叫" + name + "，我住在" + address + "，我今年" + age + "了，我的邮箱是" + email + "，我的工资是" + salary);
            Console.WriteLine("我叫{0},我住在{1},我今年{2}了,我的邮箱是{3},我的工资是{4}", name, address, age, email, salary);
            Console.ReadKey();


            //int n1 = 10;
            //int n2 = 20;
            //int n3 = 30;
            //Console.WriteLine("第一个数字是{0}, 第二个数据是{1}, 第三个数值是{2}", n1, n2, n3);
            //Console.ReadKey();

        }

        /// <summary>
        /// 这个方法的作用就是求两个整数的最大值
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回比较大的整数</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

    }
}
