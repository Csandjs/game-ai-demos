using System;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("第五日练习1  if else if");
        // Console.Write("请输入你的分数：");
        // int score = int.Parse(Console.ReadLine());
        // if (score >= 90)
        // {
        //     Console.WriteLine("你的成绩评级为:优秀");
        // }
        // else if  (score >= 60 )
        // {
        //     Console.WriteLine("你的成绩评价为：及格");
        // }
        // else
        // {
        //     Console.WriteLine("你的成绩评价为：不及格");
        // }
        
        
        
        // Console.WriteLine("====练习2===  switch");
        // Console.Write("请输入数字1~7:");
        // int day = int.Parse(Console.ReadLine());
        // switch(day)
        // {
        //     case 1 :
        //     Console.WriteLine("星期一");
        //     break;
        //     case 2 :
        //     Console.WriteLine("星期二");
        //     break;
        //     case 3 :
        //     Console.WriteLine("星期三");
        //     break;
        //     case 4 :
        //     Console.WriteLine("星期四");
        //     break;
        //     case 5 :
        //     Console.WriteLine("星期五");
        //     break;
        //     case 6 :
        //     Console.WriteLine("星期六");
        //     break;
        //     case 7 :
        //     Console.WriteLine("星期日");
        //     break;
        //     default  :
        //     Console.WriteLine("输入有误请输入1~7");
        //     break;


        // Console.WriteLine("====练习3==== 三元运算符");
        // //三元运算符判断奇偶性
        // Console.Write("请输入一个整数：");
        // int num = int.Parse(Console.ReadLine());
        // string result = num % 2 == 0 ? "偶数":"奇数";
        // Console.WriteLine(num + "是" + result);

        // //三元运算符取较大值
        // Console.Write("请输入第一个数：");
        // double a = double.Parse(Console.ReadLine());
        // Console.Write("请输入第二个数：");
        // double b = double.Parse(Console.ReadLine());
        // double max = a > b ? a : b;
        // Console.WriteLine("较大的数是：" + max);

        // //判断是否及格
        // Console.Write("请输入分数：");
        // int score1 = int.Parse(Console.ReadLine());
        // string pass = score1 >= 60 ? "及格" : "不及格";
        // Console.WriteLine("你的成绩：" + pass);

        // Console.WriteLine("====练习4====  for循环");
        // Console.WriteLine("===  打印1到20  ===");
        // for ( int i = 1 ; i <= 20 ; i++)
        // {
        //     Console.Write( i + " ");
        // }

        // Console.Write("\n=== 1到100的和 ===");
        // int sum = 0 ;
        //  for( int i = 1; i <= 100;i++)
        // {
        //     sum = sum + i ;
        // }
        // Console.WriteLine("\n1到100总和为：" + sum);

        // Console.WriteLine("\n=== 1到100中所有偶数 ===");
        // int number = 0;
        // for ( int i = 1 ;i <= 100; i++ )
        // {
        //     if(i % 2 == 0)
        //     {
        //         Console.Write(i + " ");
        //         number++;
        //     }
        // }
        // Console.WriteLine("\n1到100偶数的个数" + number);

        // Console.WriteLine("====练习5====  while循环");
        // Console.WriteLine("=== 打印1到10");
        // int i = 1; 
        // while (i <= 10)
        // {
        //     Console.Write( i + " ");
        //     i++;
        // }
        // Console.Write("\n");

        // Console.WriteLine("求1到100的和");
        // int n = 1;
        // int sum = 0;
        // while (n <= 100)
        // {
        //     sum = sum + n ;
        //     n++;
        // }
        // Console.WriteLine("总和：" + sum);

        // Console.WriteLine("=== 输入q退出 ===");
        // string input = "";
        // while(input != "q")
        // {
        //     Console.Write("请输入，按q键结束");
        //     input = Console.ReadLine();
        //     Console.WriteLine("你输入了：" + input);
        // }
        // Console.WriteLine("已退出");
        // Console.WriteLine("输入的最终结果" + input);

        // Console.WriteLine("练习6 break continue");
        // Console.WriteLine("=== break：遇到7退出循环 ===");
        // for (int i = 1; i <= 10; i++)
        // {
        //     if (i == 7)
        //     {
        //         break;
        //     }
        //     Console.Write(i + " ");
        // }

        // // 练习2：continue，跳过7
        // Console.WriteLine("\n=== continue：跳过7不退出循环 ===");
        // for (int i = 1; i <= 10; i++)
        // {
        //     if (i == 7)
        //     {
        //         continue;
        //     }
        //     Console.Write(i + " ");
        // }

        // // 练习3：打印1-30里所有不是5的倍数的数
        // Console.WriteLine("\n=== 1-30跳过5的倍数 ===");
        // for (int i = 1; i <= 30; i++)
        // {
        //     if (i % 5 == 0)
        //     {
        //         continue;
        //     }
        //     Console.Write(i + " ");
        // }

        // // 练习4：找1-100里第一个能被13整除的数
        // Console.WriteLine("\n=== 第一个能被13整除的数 ===");
        // for (int i = 1; i <= 100; i++)
        // {
        //     if (i % 13 == 0)
        //     {
        //         Console.WriteLine(i);  // 应该是13
        //         break;
        //     }
        // }
        // Console.WriteLine("=== 练习7 嵌套循环 ===  九九乘法表");
        // for ( int i =1 ; i <= 9 ; i++)
        // {
        //     for (int j = 1 ;j <= i ; j++)
        //     {
        //         Console.Write( i + "x" + j + "=" + (i * j) + "\t");
        //     }
        //     Console.WriteLine();
        // }

        // string correctPassword = "123456" ;
        // bool isSuccess = false ;
        // string inputs = "";
        // int times = 2 ;
        // do
        // {
        //   Console.Write("请输入密码：");
        //   inputs = Console.ReadLine();
        //   if (inputs == correctPassword)
        //     {
        //         Console.WriteLine("密码正确，欢迎！！");
        //         isSuccess = true ;
        //         break ;            }
        //     else
        //     {
        //         if (times>0)
        //         {
        //         Console.WriteLine("密码错误，还剩" + times + "次");
        //         times--;
        //         }
        //         else break;
        //     }
        // }
        // while(inputs != correctPassword);
        // if  (isSuccess = false)
        // Console.WriteLine("密码错误，账号已锁定");

        Console.WriteLine("晚间练习猜数字游戏");
        Random random = new Random();
        int answer = random.Next(1,101);
        int guess = 0;
        int count = 0;
        while(true)
        {
            Console.Write("请输入你猜的数：");
            guess = int.Parse(Console.ReadLine());
            count++;
            if (guess == answer)
            {
                Console.WriteLine("恭喜你猜中！！答案就是：" + answer);
                Console.WriteLine("你一共猜了" + count + "次");
                break;
            }
            else if(guess > answer)
            {
                Console.WriteLine("你猜大了");
            }
            else
            {
                Console.WriteLine("你猜小了");
            }
        }
        
        Console.ReadKey();
    }
        
}