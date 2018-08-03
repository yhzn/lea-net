using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.属性
{
    class Persion
    {


        private int age;
        private string name;
        
        // 属性（p0s:只要类中的字段要被外界访问，就要封装为属性）
                 
        // 属性的本质是一个 get set 方法，而在set 方法中定义了一个参数value,所以在set中可以使用value  在get中不能使用
        // 属性是对字段的封装
        // 属性命名规范大写
        // 属性本身不存值，值是存在这个属性所封装的字段中（name）
        // 属性的返回值与其所封装的字段没有关系
        // 属性的返回值决定了get返回值得类型和set 参数的类型
        // 自动属性：如果对一个字段取值和赋值的时候 没有任何逻辑验证 并且可读可写的时候就可以写成：public string Name {get;set;} 形式。即：自动属性

        // 属性是对字段的封装 如 Name 是对name字段的封装，但自动属性在生成程序集的时候，会为这个自动属性自动生成一个成员变量被这个自动属性所封装
        public string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                // value 是哪来的

                if (value == "")
                {
                    name = "没有名称";
                }
                else
                {
                    name = value;
                }
            }
        }
        private bool gender;

        //public bool Gender
        //{
        //    get { return gender; }
        //    set { gender = value; }
        //}

        // 只能读值，不能设置值需要写 get 块
        //public bool Gender
        //{
        //    get { return gender; }
        //}

        // 只写属性只要写set属性：只能赋值，但取不到值
        //public bool Gender
        //{
        //    set { gender = value; }
        //}

        // 如果封装字段值类型 和get set 返回值类型不同 赋值时需要转换
        // string 是 set 参数 value值类型，get 返回值类型
        public string Gender
        {
            get { return gender==true?"男":"女"; }
            set { gender = value=="男"?true:false; }
        }

        // 将年龄范围做校验 
        // 1.将年龄属性私有化，使外界不能访问
        // 2.私有化属性设置，返回
        public void setAge(int value)
        {
            if (value >= 0 && value <= 120)
            {
                age = value;
            }
            else
            {
                age = 18;
            }
        }
        public int getAge()
        {
            return age;
        }

        public void SayHi()
        {
            Console.WriteLine("我是{0}，今年{1}", name, age);
        }
    }
}
