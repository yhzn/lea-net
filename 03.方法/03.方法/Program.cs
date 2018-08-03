using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(); 
            // Test("i",1); 
            // Test(2,"i");

			// 可变参数
			// 1.params 只能用来修饰方法的参数 参数必须是一个一维数组
			// 2.参数列表中最多只能出现一个可变参数 
			// 3.可变参数不能使用默认值 如 static void TestParams(params int[] arr={1,2,3})
            // 4.判断用户有没有给可变参数传值，可判断可变参数数组的长度是不是为零 arr.Length==0，但不能用arr==null判断，因arr不等于null



			// 不用可变参数可以这样传
            //int[] arr = new int[3];
            //TestParams(arr);

            // 使用可变参数，可以直接传递数组元素

            
            
            TestParams(1, 2, 3, 4, 5, 6); 
            // 调用的时候可以直接传递一个 int的数组变量 如：TestParams(arr) 也可以直接传递数组的元素
            
            // 若传递元素的时候，相当于做如下处理
            // int[] arr={1,2,3,4,5,6}
            // TestParams(arr)
            int i = 12;
            // ref 修饰方法的参数 1.在调用时必须在变量前面加 ref 关键字 2.只能传递变量
            // 不能直接传递数值 如：TestRef(ref 12);
            TestRef(ref i);
            Console.WriteLine(i);
            int[] arr={3,6,2,9,0,1};
            int max=0;
            int min=0;
            GetMaxAndMin(arr,out max, out min);
            Console.WriteLine("max:" + max + "," + "min:" + min);
            
            string str="qw123";
            int testNum;
            if(MyIntPase(str,out testNum)){
            	Console.WriteLine("转换成功");
            }else{
                Console.WriteLine("转换失败");
            }


            // 微软中有封装好的方法
            if(int.TryParse(str,out testNum)){
            	// 也可以用 bool 值接收
            	bool b=int.TryParse(str,out testNum);
            };

            Console.ReadKey();
        }

        static void TestParams(params int[] arr)
        {
            // 给可变参数赋值时，可以直接传递数组的元素
            // 在调用时会自动将这些元素封装为一个数组 并传递数组
            Console.WriteLine(arr[1]);

        }
        // 可变参数数组必须参数列表的最后
        static void Test1Params(int i,int j,params int[] arr)
        { 
        }
        
        // 方法重载
        // 在同一个作用域下 不能定义名字相同的成员
        // 参数类型不同时，方法名可以相同

        // 什么情况下可以方法重载
        // 1.方法名要一样 2.方法参数的个数 或者类型不一样 3.方法必须在同一个类中 4.与返回值无关

        // 可变参数
        // 参数被params修饰 params只能用来修饰一维数组


        static void Test(string str)
        {
            Console.WriteLine("str");
        }
        static void Test(int i)
        {
            Console.WriteLine("int");
        }
        static void Test(string str, int i)
        { 
            Console.WriteLine("参数个数不一样可以重载");
        }
        static void Test(int i, string str)
        {
            Console.WriteLine("参数顺序不一样可以重载");
        }
        static void Test()
        {
            Console.WriteLine("default");
        }




        // ref 修饰方法的参数 
        // 1.在调用时必须在变量前面加 ref 关键字 
        // 2.只能传递变量 
        // 3.ref赋值不能给常量，必须变量
        // 4.ref赋值的时候是变量的地址
        // 5.ref在传递之前必须赋初始值

        // ref 修饰不是传递变量的值 而是传递变量的地址 所以函数内部变化在外部可以读取到
        static void TestRef(ref int i)
        {
            i++;
        }

        // out 也是传递变量的地址
        // out 与 ref 区别
        // 1.out 必须在方法结束之前赋值 2.ref 可以修改值也可以不修改值
        // out 侧重于输出 ref侧重修改
        // out 传递前变量可以不赋初始值，因为在方法中会赋值
        // ref 传递前必须赋值，因为方法中可能会用到这个参数值
        static void TestOut(out int i)
        {
            i = 11;
        }
        // 如获取最大值最小值
        static void GetMaxAndMin(int[] arr,out int max,out int min)
        {
            for(int i=0;i<arr.Length-1;i++)
            {
                  for(int j=0;j<arr.Length-i-1;j++)
                  {
                      if(arr[j]>arr[j+1])
                      {
                         int temp=arr[j];
                          arr[j]=arr[j+1];
                          arr[j+1]=temp;
                      }
                  }
            }
            max=arr[arr.Length-1];
            min=arr[0];
        }

        // 写一个方法：将一个字符串转换为int类型，如果转换成功，返回true 并输出转换成功的值，如果转换失败，返回 false

		static void MyIntPase(string str,out int num)
		{

			try
			 {
				num=int.Pase(str);
				return true;
			}
			catch(Exception ex)
			{
				num=0;
				return false
			}

		}
    }
}
