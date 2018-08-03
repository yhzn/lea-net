using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class Program
    {
        // F5:将解决方案下的所有的项目编译成程序集 并运行当前程序集
        // F6:将解决方案下的所有项目编译成程序集
        // 程序的入口是Main函数 一个项目中 Main函数最多只能有一个
        // 程序退出两种情况：
        // 1.用户主动关闭 2.Main函数执行完毕
        static void Main(string[] args)
        {
            // 解决方案 用来管理项目的
            Console.WriteLine("Hello World !");

            // 数据类型 


            // 1.在内存里开辟空间的时候要指定空间类型
            // 2.每种数据类型在内存中开辟多大空间是根据这个数据的最大值来确定的
            // 3.数据类型就是在内存中开辟大小的一个模板
            // 4.数据类型大小由微软事先规定好开辟空间大小

            // 内存中开辟空间的方法
            // 数据类型 变量名；
            int i; // 开辟 int 类型的内存空间  
            // 变量使用之前必须要为变量赋值
            i = 12; // 赋值 两边的数据类型要一致

            // 类型转换

            byte j = 15;

            i = j;
            Console.WriteLine("j=" + j + ";" + "i=" + i);
            // 可以进行隐式数据转换 满足数据转换条件 
            // 1.数据类兼容 
            // 2.目标类型要大于源类型 
            
            // j = i 不可进行隐式数据转换 int 的值不在 byte范围内赋值给byte会有问题 
            // 若明知有问题还要转换 可用强制类型转换

            // 强制类型转换

            int i1 = 13;
            byte j1 = 18;
            j1=(byte)i1; // 强制类型转换 
            Console.WriteLine("j1="+j1+";"+"i1="+i1);

            // 数据不兼容下的类型转换

            // 字面量是int类型的可以进行转换 如：
            string str = "123";     // string str="1sdf23";string str="13.12"; 不能进行类型转换
            int c = int.Parse(str); // parse 只能转换字符串
            Console.WriteLine(c);

            // 强制转换是内存意义上的转换
            // 其他类型的转换为int的转换 如：
            bool b1 = true;
            // Convert 是根据变量意义转换
            int bi = Convert.ToInt32(b1);

            // 如果将 string 转换为 int Parse 转换和 Convert 转换有什么区别
            // Convert 将string 转换为 int 实际就是内部调用 int.parse() 方法
            // 只不过在调用前判断了字符串的值是不是null
            // 如果是null返回0 
            // 而int Parse 字符串的值为 null则抛异常

            // string str1 = null;
            // int i10 = int.Parse(str1);       // 抛异常
            // int i11 = Convert.ToInt32(str1); // 返回0

            Console.WriteLine("bi=" + bi);

            Console.WriteLine(int.MinValue + ":" + int.MaxValue);
            Console.WriteLine(byte.MinValue + ":" + byte.MaxValue);

            // 变量 就是在内存中开辟的空间
            // 每一个空间根据地址确定
            // 变量名：就是为这个空间取得别名
            // 变量的类型：就是这个变量所对应那个空间的数据类型
            // 变量的值：就是对应空间里的值


            // 当程序运行到这句代码的时候程序会暂停，当按下键盘的任意一个键的时候 程序会继续往下运行
            Console.ReadKey();

          

        }
    }
}
