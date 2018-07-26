using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // .net是一个平台，c#是一门语言
            // c#语言通过.net平台编写.net程序
            // .net平台重要组成：
            // 1.FCL框架类库：微软将我们在编程过程中经常用到的功能，写成类，这些类的集合叫框架集 
            // 2.CLR：公共语言运行时：是.NET程序创建、部署、运行的必备环境

            // 数据类型就是在内存中开辟大小的模板
            // 预定义数据类型
            // 自定义数类型
            
            // 数据类型转换：
            // 隐式转换：1.数据类型要兼容 2.目标类型要要大与源类型
            // 强制转换：1.数据类型要兼容 2.需要显示进行转换，因为要将一个小的数据类型放到一个大的数据类型中，这样做的话可能会发生问题，需要考虑问题有无影响

            // parse 转换：1.只能转换字符串 2.字面量是指定的数据类型才有可能成功
            // Convert 转换：1.不仅能转换字符串还可以装换其他类型 万能转换 2.convert 转换字符串时调用的是 parse转换，不同的是convert 参数值为null时返回0，parse转换参数值为null时，则抛出异常

            

            // 数组
            // 声明int数组
            int[] arr = new int[4];

            // 值类型：所有数值类型 char 枚举 结构 （直接将数据存储在栈里的空间里面）

            // 引用类型：string 数组 类
            // 变量声明在栈里面 真时的对象储存在堆里面 栈里面储存的是对象地址
            // 将一个变量的值赋值给另外一个变量，无论怎样都是将一个变量的值拷贝一份给另外一个变量，不同的是引用类型在变量里存的是内存地址
            int i = 12;
            Test1("测试");
            Console.WriteLine(i);
            Console.ReadKey();
        }
        // 调用带参数的方法的时候 参数类型要一致 个数一致 顺序一致
        // 带默认 值得参数要放在参数列表的最右边
        // 变量使用之前必须赋值
        static void Test1(string str, int i = 2) 
        {
            i++;
            Console.WriteLine("test:"+i);
        }
    }
}
