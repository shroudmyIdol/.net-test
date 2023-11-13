using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class练习
{
    public class Person
    {
        string _name;
        int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            //当输出属性的值的时候，会调用该方法
            get { return _age; }
            //当给属性赋值的时候，会调用改方法
            set
            {

                if (value < 0 || value > 100)
                {
                    value = 0;
                }

                _age = value;
            }

        }

        public void CHLSS()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了", this.Name, this.Age);
        }
    }
}
