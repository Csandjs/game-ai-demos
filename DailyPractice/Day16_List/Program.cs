class Program
{
    static void Main(string[] args)
    {
        // List<string> bag = new List<string>();
        // Console.WriteLine("当前物品数量：" + bag.Count);
        // bag.Add("木剑");
        // bag.Add("回血药水");
        // bag.Add("金币");
        // Console.WriteLine("当前物品数量：" + bag.Count);
        // Console.WriteLine(bag[0]);
        // bag[0] = "铁剑";
        // Console.WriteLine("----遍历背包----");
        // foreach(string item in bag)
        // {
        //     Console.WriteLine("被包里有：" + item);
        // }
        // Console.WriteLine("----喝掉药水----");
        // bool removed = bag.Remove("回血药水");
        // Console.WriteLine("删除成功了吗：" + removed);
        // Console.WriteLine("现在数量：" + bag.Count);
        // Console.WriteLine("----查查东西在不在----");
        // Console.WriteLine(bag.Contains("金币"));
        // Console.WriteLine(bag.Contains("回血药水"));
        // Console.WriteLine(bag.Remove("屠龙刀"));
        // Console.WriteLine("----删除后的背包----");
        // foreach(string item in bag)
        // {
        //     Console.WriteLine(item);
        // }
        List<string> bag = new List<string>{"木剑", "小回血药水", "金币", "大回血药水", "蓝瓶药水"};
        string frist = bag.Find(item => item.Contains("药水"));
        Console.WriteLine("第一瓶药水：" + frist);
        List<string> potions = bag.FindAll(item => item.Contains("药水"));
        Console.WriteLine("所有药水数量：" + potions.Count);
        foreach(string p in potions)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("背包里有剑吗：" + bag.Exists(item => item.Contains("剑")));
        List<int> damages = new List<int>{ 5, 12, 30, 8, 25};
        List<int> bigHits = damages.FindAll(x => x > 10);
        Console.WriteLine("大于10的伤害有：" + bigHits.Count);
        Console.WriteLine("排序前：" + string.Join(" " , damages));
        damages.Sort();
        Console.WriteLine("默认排序：" + string.Join(" ", damages));
        damages.Sort((a, b) => b - a);
        Console.WriteLine("降序排序：" + string.Join(" ", damages));
        damages.Sort((a, b) =>a - b);
        Console.WriteLine("使用a - b后：" + string.Join(" ", damages));
    }
}