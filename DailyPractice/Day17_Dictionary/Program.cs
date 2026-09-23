using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string , int> attrs = new Dictionary<string, int>();
        attrs.Add("血量" , 100);
        attrs.Add("攻击" , 25);
        attrs.Add("防御" , 10);
        Console.WriteLine("攻击：" + attrs["攻击"]);
        Console.WriteLine("血量：" + attrs["血量"]);
        if (attrs.ContainsKey("暴击"))
        {
            Console.WriteLine("暴击：" + attrs["暴击"]);
        }
        else
        {
            Console.WriteLine("没有暴击这个属性");
        }
        attrs["攻击"] = 30;
        attrs["暴击"] = 20;
        Console.WriteLine("现在攻击：" + attrs["攻击"]);
        if (attrs.ContainsKey("暴击"))
        {
            Console.WriteLine("暴击：" + attrs["暴击"]);
        }
        else
        {
            Console.WriteLine("没有暴击这个属性");
        }
        if(attrs.TryGetValue("防御", out int defense))
        {
            Console.WriteLine("防御是：" + defense);
        }
        else
        {
            Console.WriteLine("查无此属性");
        }
        //attrs.Add("攻击" , 99);
        bool removed = attrs.Remove("防御");
        Console.WriteLine("防御被删除了吗：" + removed);
        Console.WriteLine("现在有几对属性：" + attrs.Count);
        foreach(var kv in attrs)
        {
            Console.WriteLine(kv.Key + ":" + kv.Value);
        }
        foreach(string key in attrs.Keys)
        {
            Console.WriteLine("有个属性叫：" + key);
        }
        foreach(int value in attrs.Values)
        {
            Console.WriteLine("有个数值为：" + value);
        }
    }
}