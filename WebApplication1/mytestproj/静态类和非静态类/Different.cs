using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态类和非静态类
{
    public class Different
    {
        public void M1()
        {
            Console.WriteLine("我是非静态类方法");
        }

        public static void M2()
        {
            Console.WriteLine("我是静态类方法");
        }
    }
}
