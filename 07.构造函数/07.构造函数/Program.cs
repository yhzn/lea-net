using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            //Dog d = new Dog(12);
            //Dog dp = new Dog(2,"二哈");
            //Console.WriteLine(dp.Age + ":" + dp.Name);            
            //dog.SayHi();
            Ticket t = new Ticket(200);

            Console.ReadKey();
        }
    }
}
