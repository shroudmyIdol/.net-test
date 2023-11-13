using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建Person类的对象
            Person person = new Person();
            person.Name = "韩健";
            person.Age = -25;

            person.CHLSS();

            Console.ReadKey();
        }
    }
}
