using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构
{

    public struct Person
    {
        public string _name; //字段
        public int _age;
        public Gender _gender;
    }

    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }

    public enum Gender
    {
        男,
        女
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 10;
            zsPerson._gender = Gender.男;

            MyColor myColor;
            myColor._red = 255;
            myColor._green = 0;
            myColor._blue = 255;

        }
    }
}
