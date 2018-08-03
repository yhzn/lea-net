using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // .net是一个平台，c#是一门语言
            // c#语言通过.net平台编写.net程序
            // .net平台重要组成：
            // 1.FCL框架类库：微软将我们在编程过程中经常用到的功能，写成类，这些类的集合叫框架集 
            // 2.CLR：公共语言运行时：是.NET程序创建、部署、运行的必备环境

            // 数据类型就是在内存中开辟大小的模板
            // 预定义数据类型
            // 自定义数类型
            
            // 数据类型转换：
            // 隐式转换：1.数据类型要兼容 2.目标类型要要大与源类型
            // 强制转换：1.数据类型要兼容 2.需要显示进行转换，因为要将一个小的数据类型放到一个大的数据类型中，这样做的话可能会发生问题，需要考虑问题有无影响

            // parse 转换：1.只能转换字符串 2.字面量是指定的数据类型才有可能成功
            // Convert 转换：1.不仅能转换字符串还可以装换其他类型 万能转换 2.convert 转换字符串时调用的是 parse转换，不同的是convert 参数值为null时返回0，parse转换参数值为null时，则抛出异常

            

            // 数组
            // 声明int数组
            int[] arr = new int[4];

            // 值类型：所有数值类型 char 枚举 结构 （直接将数据存储在栈里的空间里面）

            // 引用类型：string 数组 类
            // 变量声明在栈里面 真时的对象储存在堆里面 栈里面储存的是对象地址
            // 将一个变量的值赋值给另外一个变量，无论怎样都是将一个变量的值拷贝一份给另外一个变量，不同的是引用类型在变量里存的是内存地址
            int i = 12;
            Test1("测试");
            Test2();
            TestJiaoChuo();
            // 顺序不一致调用情况
            // Test1(i:"18",str:"测试") // key值与声明参数相同
            Console.WriteLine(i);
            Console.ReadKey();
        }
        // 调用带参数的方法的时候 参数类型要一致 个数一致 顺序一致
        // 带默认 值得参数要放在参数列表的最右边
        // 变量使用之前必须赋值
        static void Test1(string str, int i = 2) 
        {
            i++;
            Console.WriteLine("test:"+i);
                                                                                                                                                      
        }

        static void TestSwitch() 
        {
        // switch 只能判断整值 不能做范围判断( 即 case score>=90&&score<100: 不能这样表示  ) if else 即可以判断整值 也可以判断范围
            int score = 78;
            switch (score/10) { // 整数型 90>=score<100 可取整数9
                case 10:
                case 9: // 为 90~100
                    Console.WriteLine("A"); 
                    break;
                case 8: // 80~90
                    Console.WriteLine("B");
                    break;
            }
        }
        static void TestWhile() 
        {
            // while 先判断条件是否成立在执行 要有结束条件
          while(true)
          {
              Console.WriteLine("while 循环");
          }
            // do while 先执行一次 在根据条件判断是否执行 至少执行一次
          do
          {
              Console.WriteLine("do while");
          } while (true);


          for (int i = 0; i < 10; i++)
          {
              Console.WriteLine("for ");
          }
        }
        static void Test2()
        {
         // 数组长度不可变

            // 二维数组
            int[,] arr = new int[2, 3]; 
            // 定义一个两行三列的数组 即arr.length=2*3  arr[0].length=3 arr[1].length=3; arr.length 表元素个数，值为 行*列
            Console.WriteLine(arr.Length);

            // 二维数组赋值
            arr[0, 1] = 2;
            
            // 遍历


            // foreach 可以进行遍历 但不能改变数组的值
            // foreach (int i in arr) 
            // {
            //    Console.WriteLine(i);
            // }

            // 2行 3列 可以用 arr.GetLength() 方法得到指定维度的长度
            // arr.GetLength(0) 得到行
            // arr.GetLength(1) 得到列
            // arr.Rank 获取数组的维度
            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.WriteLine(arr[i, j]);
                }
            }


        }
        static void testDuoWei()
        { 
        // 可以有三维、五维、八维、更多维
            // 三维数组声明 x,y,z
            int[,,] arr=new int[3,4,5]; // x是3 y是4 z是5 

        }
        static void TestJiaoChuo()
        { 
            // 交错数组 交错数组的本质是1个1维数组 只不过这个1维数组的元素又是数组

            // int[][] 表示数组的数组  new int[3][] 只需要指定一维数组的长度，元素下数组的长度不需要指定
            int[][] arr = new int[3][]; 
            // 声明为[int[],int[],int[]] int[]默认为null 遍历会出错
            // 需要赋值处理
            arr[0] = new int[3];
            arr[1] = new int[5];
            arr[2] = new int[6]; // 可避免值为 null 时的报错
            Console.WriteLine("--- 交错数组 start ---");
            //foreach (int[] item in arr)
            //{
            //    foreach (int i in item)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // for 循环遍历
            for (int i = 0; i < arr.Length; i++) 
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }

            // 另一种形式的交错数组
            int[][][] arr1 = new int[3][][]; // 表示一维数组下的元素是个数组，一维元素的元素又是个数组
            Console.WriteLine("--- 交错数组 end ---");
        }





    }
}
