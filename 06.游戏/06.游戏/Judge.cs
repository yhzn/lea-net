using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.游戏
{
    class Judge
    {
        public void CaiJue(int p1, int p2)
        { 
        // 判断输赢
            // 1.剪刀 2.石头 3.布
            // 玩家赢得条件
            // 玩家出  计算机出  差值
            //    1       3       -2
            //    2       1        1
            //    3       2        1
            if (p1 - p2 == -2 || p1 - p2 == 1)
            {
                Console.WriteLine("玩家赢");
            }
            else if (p1 == p2)
            {
                Console.WriteLine("平局");
            }
            else 
            {
                Console.WriteLine("玩家输");
            }
        }
    }
}
