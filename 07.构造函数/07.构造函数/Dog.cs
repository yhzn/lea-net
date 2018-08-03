using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.构造函数
{
    class Dog
    {
        // 构造函数语法
        // 1.访问修饰符一般情况下是 public
        // 2.没有返回值（连void都不用写）
        // 3.方法名与类名一致
        // 4.构造函数在创建对象的时候自动调用，无法手动调用
        // 5.构造函数可以有参数
        // 6.this关键字代表当前对象
        // 7.构造函数可以重载
        // 8.构造函数中可以调用普通方法（ps:构造函数不能再普通方法中调用，但构造函数可以相互调用 有this调用）
        // 9.this 关键字可以调用其他构造函数，:this() 方法中传入构造函数中参数
        // 10.多构造函数执行顺序，从右向左执行（如：无参数构造函数调用 2参数构造函数 2参数构造函数有调用 1参数构造函数（ps:该顺序为调用顺序），则执行顺序为： 1->2->无参数函数构造函数）

        // 11.如果类中没有添加构造函数，那么c#编辑器在编辑的时候会自动为这个类生成一个无参数的构造函数，这个函数叫：隐式构造函数
        // 12.如果手动添加任意构造函数，编辑器不会为类添生成一个无参数的构造函数
        
        public Dog():this(22,"哈哈")
        {
            Console.WriteLine("无参的构造函数");
        }
        public Dog(int num)
        {
            Console.WriteLine("含一个参数的构造函数：{0}",num);
        }
       
        // 构造函数用途
        // 如果希望在创建类的同时创建一些代码，就可把这些代码写在构造函数中
        // 大多时候是初始化字段

        // 一个构造函数调用一个参数的构造函数方法，:this("对应构造函数所需传入的构造函数")

        // 可以将构造函数中的 参数 如:age 直接传给this 如：this(age)
        public Dog(int age, string name):this(age) 
        {
            // this 带指当前对象，当前运行在内存中的对象
            // 如果参数名和属性名不一致可以不加 this 关键字，如果一样需要加 this 关键字，表明是这个对象下的属性，而不是函数中的方法
            // 如果直接赋值 age=age 表明参数是自己给自己赋值，会报错
            this.age = age;
            this.name = name;
            // 这个方法可以不加 this ,为了代码阅读性，可以加，显示调用
            this.Shout();
            Console.WriteLine("hi:构造函数初始化的名字为:{0}，年龄为:{1}", name, age);
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
   
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void Shout()
        {
            Console.WriteLine("叫声：汪汪汪......!");
        }
        public void SayHi()
        {
            Console.WriteLine("hi:我是{0}，今年{1}", name, age);

        }

  
    }
}
