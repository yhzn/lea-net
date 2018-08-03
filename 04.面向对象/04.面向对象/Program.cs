using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.面向对象
{
    // 变量命名规范

    // 1.只有一个单词，全部小写
    // 2.如果有多个单侧，除第一个单词，其他单词首字母都要大写
    // 3.如果是个缩写，则字母全都要大写
    // 4.命名要有意义
    // 5.变量名是名词


    // 方法名

    // 1.每个字母的首字母大写
    // 2.方法名是动词


    // 类名

    // 1.每个首字母大写
    // 2.是个名词


    // 定义一个类，一般一个类写在一个文件中

    // 调试 F10 F11 在调试过程中监视变量的值 改值 运行表达式
    class Program
    {
        private string x;

        static void Main(string[] args)
        {
            Program p=new Program();
            p.x="私有变量在本类中是可以访问的 即使是实例化的"
            // 创建类的对象
            // 类名 对象名 = new 类名();

            // new 是一个运算符 
            // 1.在内存中开辟一块合适的大小空间 
            // 2.在这个空间中创建对象 
            // 3.调用这个对象的构造函数 
            // 4.返回这个空间的引用地址

            // 同一个命名空间的类可以直接访问 不同命名空间的类不可以直接访问

            // 若为非同名命名空间的访问可用如下的访问方式：
            // 1.类的全名称访问：命名空间名.类名 p = new 命名空间名.类名();
            // 2.用 using 命名空间名称 方式引入，就可以访问该命名空间下所有的类
            Person p1 = new Person();
            Person p2 = new Person();
            p1.age = 23;
            p1.Sing();

            // 类的访问修饰符（只有两种）
            // public         
            // internal 默认

            // console 是system 程序集下的类 可以全名称访问 System.Console.   如果一个类没有访问成功，可能这个程序集没有引入 在项目的引用文件中添加引用（如：System.Windows.Forms.Cursor c; 需要添加System.Windows.Forms的引用）
            Console.WriteLine(p2.age);
            Console.ReadKey();
        }
    }
}
