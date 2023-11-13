using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 找出100以内的所有质数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                bool b = true;

                for (int j = 2; j < i; j++)
                {
                    // 除尽了说明不是质数
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }

                if (b)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
