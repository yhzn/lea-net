using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.游戏
{
    class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ShowFist()
        {
            Console.WriteLine("请问你要出什么，1.剪刀,2.石头,3.布");
            int useSelect = ReadInt(1, 3);
            Console.WriteLine("玩家:{0}出了{1}",Name,IntToFist(useSelect));
            return useSelect;
        }
        private int ReadInt(int min,int max)
        {
            int i = 0;
            while (true)
            {

                Console.WriteLine(i++);
                string str = Console.ReadLine();
                int useSelect;
                if (int.TryParse(str, out useSelect))
                {
                    if (useSelect >= min && useSelect <= max)
                    {
                        return useSelect;
                    }
                    else
                    {
                        Console.WriteLine("请输入{0}~{1}的整数", 1, 3);
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("请输入一个整数");
                }

            }
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
                    fist="石头";
                    break;
                case 3:
                    fist="布";
                    break;
                default:
                    fist = "没有该选项";
                    break;
            }
            return fist;
        }
    }
}
