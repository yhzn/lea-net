using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.游戏
{
    class Program
    {
        static void Main(string[] args)
        {
            // 调用
            int numA = 12;
            int numB = 2;
            Calc calc = new Calc();
            Console.WriteLine(calc.GetSum(numA, numB));
            Player player = new Player() { Name="lili"};
            int p1=player.ShowFist();
            int p2=calc.ShoeFist();
            Judge judge = new Judge();
            judge.CaiJue(p1, p2);
            Console.ReadKey();
        }
    }
}
