using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.游戏
{
    // 计算器类 用来计算两个数的结果
    class Calc
    {
        // 类下只能写 字段 方法 属性
        Random r = new Random();
        public int ShoeFist()
        {
            // 执行语句只能写在方法中
            int comSelect = r.Next(1,4);
            Console.WriteLine("计算机出了：{0}",IntToFist(comSelect));
            return comSelect;

        }
        private string IntToFist(int useSelect)
        {
            string fist = string.Empty;
            switch (useSelect)
            {
                case 1:
                    fist = "剪刀";
                    break;
                case 2:
                    fist = "石头";
                    break;
                case 3:
                    fist = "布";
                    break;
                default:
                    fist = "没有该选项";
                    break;
            }
            return fist;
        }

        public int GetSum(int numA,int numB)
        {
            return numA + numB;
        }
        public int GetCha(int numA, int numB)
        {
            return numA - numB;
        }
        public int GetShang(int numA, int numB)
        {
            return numA / numB;
        }
        public int GetJi(int numA, int numB)
        {
            return numA * numB;
        }
    }
}
