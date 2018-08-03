using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.面向对象
{
    class Person
    {
        // 属性：定义成员变量直接定义在类下面 也叫成员字段 也叫字段
        // 成员变量


        // 类的成员访问修饰符
        // public      可以在任意地方访问 
        // internal    只能在当前程序集中访问
        // private     只能在类的内部访问 是默认的访问级别
        // protected   只能在类和本类的子类中访问

        string name;  // 不写访问修饰符为 private string name
        public int age;
        public bool sex;


        // 类中不能写执行代码，执行代码只能写在方法中
        // 类中只能写 成员字段 成员方法，其他不能写（目前为止 类的成员有：字段、方法）
        // Console.WriteLine(name) 不能写


        // 成员变量和局部变量的区别
        // 1.成员变量在类中 局部变量在方法中
        // 2.成员变量申明的时候不给初始值得时候是有默认值的(值类型是0，引用类型是null) 局部变量在使用之前要赋值


        // 行为 要定义一个方法
        public void Sing()
        {
            Console.WriteLine("啊~~~~~");

        }

    }
}
