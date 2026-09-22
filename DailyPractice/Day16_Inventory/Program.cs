class Program
{
    static void Main(string[] args)
    {
        List<string> bag = new List<string>
        {
            "木剑", "回血药水", "金币", "面包", "回血药水"
        };
        Console.WriteLine("捡到火把，蓝瓶药水，金币");
        bag.Add("火把");
        bag.Add("蓝瓶药水");
        bag.Add("金币");
        Console.WriteLine("喝掉回血药水");
        bag.Remove("回血药水");
        Console.WriteLine("包里有木剑吗：" + bag.Contains("木剑"));
        List<string> potions =bag.FindAll(item => item.Contains("药水"));
        Console.WriteLine("药水瓶数：" + potions.Count);
        foreach(string p in potions)
        {
            Console.WriteLine(p);
        }
        List<string> coins = bag.FindAll(item => item.Contains("金币"));
        Console.WriteLine("金币数量:" + coins.Count);
        bag.Sort((a, b) => a.Length - b.Length);
        Console.WriteLine("排序后:" + string.Join(" ", bag));
        Console.WriteLine("最终背包物品个数:" + bag.Count);
        foreach(string b in bag)
        {
            Console.Write(" " + b);
        } 
    }
}
