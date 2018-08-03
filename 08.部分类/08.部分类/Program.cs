using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.部分类
{
    // 同一个命名空间下不能有名称相同的两个类，单用partial 修饰的类可以名称相同：这样的类叫做部分类 或者叫伙伴类
    // 特点
    // 1.其实两个类是一个类（编译器会将部分类编译成一个类，所以另外一个类中定义的成员变量可以在这个类中访问的到）
    // 2.构成条件：必须在同一个命名空间下，类名要一致


    partial class Program
    {
        static void Main(string[] args)
        {
        }
    }
    partial class Program
    { 

    }
    // 部分类使用条件   
    // 1.分开管理，方便维护

    // 只有引用类型的值才可以为null
}
