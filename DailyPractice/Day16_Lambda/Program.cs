using System;
class Program
{
    static void Main()
    {
       //形态1：多个参数，括号必须有
       Func<int, int, int> formula1 = (attack, defence) => attack * 2;
       Console.WriteLine(formula1(30, 20));
       //形态2：一个参数括号可以省
       Func<int, int> buff = atk => atk + 5;
       Console.WriteLine(buff(30));
       //形态3：无参数（配Action），空括号（）
       Action dodge = () => Console.WriteLine("闪避");
       dodge();
       //形态4：方法体不止一行->加大括号{}，这时return必须自己写
       Func<int, int, int> critical = (atk, def) =>
       {
           Console.WriteLine("触发暴击！");
           int damage = atk * 2;
           return damage;
       } ;
       Console.WriteLine(critical(30,20));   
    }
}