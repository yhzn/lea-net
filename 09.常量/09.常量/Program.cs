using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.常量
{
    class Program
    {
        // 只读变量
        readonly string sex="男";
        // 只读变量的值是不可以改变的
        // 只读变量的值 只能在构造函数中改变他的值
        // 上面的赋值也是在构造函数中赋值的 相当于
        // readonly string sex;
        // public Program()
        // {
        //    this.sex="男";
        //  }

        // readonly 是运行时确定的值
        // const 编译时必须要确定值
        static void Main(string[] args)
        {
            // const 修饰的数据叫常量
            // 常量一旦声明就不能改变
            // 常量声明时必需赋初始值
            // 编辑器在编译的时候 声明常量的那句话不见了，在常量使用的地方就用常量的值代替了

            // 使用常量的场景
            // 某些数据在整个程序的运行过程中其值不会改变 我们就把这个值定义为常量 以提高程序运行效率

            const string name = "name";
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
