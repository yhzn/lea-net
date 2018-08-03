using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.属性
{
    class Door
    {
        public void Open()
        {

            Console.WriteLine("人开门......");
        }
    }
    class People
    {
        // 类是一种数据类型 OpenDoor(Door door) 可对比理解 OpenDoor(int 2)
        public void OpenDoor(Door door)
        {
            door.Open();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            People pp = new People();
            pp.OpenDoor(door);

            Persion p = new Persion();
            p.Name = "李丽";
            p.setAge(21);
            p.Gender = "女";
            Console.WriteLine(p.Gender);
            Console.WriteLine(p.getAge());
            p.SayHi();
            Console.ReadKey();
        }
    }
}
