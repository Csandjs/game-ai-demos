//第四日晚：判断奇偶+温度转换练习
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("第四日晚练习1：判断奇偶+温度转换练习");
        Console.Write("请输入一个整数：");
        string input1 = Console.ReadLine();
        int num1 = int.Parse(input1);
        int remainder = num1 % 2;
        if(remainder == 0)
        {
            Console.WriteLine(num1 + "是偶数");
        }
        else
        {
            Console.WriteLine(num1 + "是奇数");
        }

        Console.WriteLine("练习2：温度转换");
        Console.Write("请输入摄氏温度：");
        string input2 = Console.ReadLine();
        double celsius = double.Parse(input2);
        double fahrenheit = celsius * 9.0 / 5 + 32;
        Console.WriteLine(celsius + "°C" + " = " + fahrenheit + "°F");
        Console.ReadKey();
    }
}