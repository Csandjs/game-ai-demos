using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        List<int> damages = new List<int>{ 8, 25, 12, 40, 15, 3};
        damages.Add(22);
        damages.Add(5);
        List<int> criticals = damages.FindAll(x => x >= 20);
        Console.WriteLine("暴击次数：" + criticals.Count);
        Console.WriteLine("所有暴击伤害：");
        foreach(int c in criticals)
        {
            Console.Write(" " + c);
        }
        int first = damages.Find(x => x >= 20);
        Console.WriteLine("\n第一个暴击伤害：" + first);
        damages.Sort((a, b) => b - a);
        Console.WriteLine("从大到小排序伤害数值：" + string.Join(" ",damages));
        Console.WriteLine("最高伤害：" + damages[0]);
        damages.Clear();
        damages.Insert(0 , 5);
        Console.WriteLine(string.Join(" ", damages));
    }
}