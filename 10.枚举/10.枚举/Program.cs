using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.枚举
{
    class Program
    {
        static void Main(string[] args)
        {
            // 枚举类型赋值 只能赋枚举成员的值，即值被限定
            Direction dir = Direction.East;

            Direction dir2 = dir; // 数据类型一样可以直接赋值
            Person p = new Person();
            // 在 person 类中定义枚举数据类型的成员字段，只能取枚举中定义的值，其他的值取不到

            p.dir = Direction.East;
            dir2 = Direction.South;

            // 对 dir 的值无影响，因枚举是值类型的数据

            // 枚举用点 . 点出来
            State st = State.离线;

            // 每一个枚举成员，都对应一个整型的数值，默认从 0 开始，一次递增；
            // 如果要取到该值所代表的的数值，要将 Direction 类型强制转换为 值类型
            int i = (int)dir;

            // 反向转换
            // 将整数转换所代表的的枚举值
            int j = 3;
            Direction dir3 = (Direction)j;

            // 将字符串转换成枚举值
            string str = "East";
            // Enum.Parse(typeof(Direction), str); parse 返回的是 object, 还需要进行强制转换
            // typeof() 传的是枚举类型
            // str 中赋的值必须是枚举中存在的值
            Direction dir5 = (Direction)Enum.Parse(typeof(Direction), str,true); // 添加一个参数true 可以忽略大小写转换

            // ToString() 将任意类型转换为字符串方法

            // 将枚举成员对应的值类型转化为字符串
            string s1 = dir5.ToString("d");

            Console.WriteLine(s1+":"+dir5);

            Console.WriteLine(i+":"+dir+"；依据整数转换的枚举值："+dir3);
            Console.ReadKey();

        }
    }
}
