﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out参数练习
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            bool b = MyTryParse("123abc", out num);

            Console.WriteLine(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }


        public static bool MyTryParse(string s, out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
