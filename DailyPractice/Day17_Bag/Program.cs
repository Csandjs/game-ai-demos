class Program
{
    static void PickUp(Dictionary<string , int> bag , string itemName)
    {
        if (bag.ContainsKey(itemName))
        {
            bag[itemName]++;
        }
        else
        {
            bag[itemName] = 1;
        }
    }
    static void Main(string[] args)
    {
        Dictionary<string , int> bag = new Dictionary<string, int>
        {
            { "药水", 2 } , {"金币", 5 }
        };
        PickUp(bag , "药水");
        PickUp(bag , "药水");
        PickUp(bag , "金币");
        PickUp(bag , "剑");
        foreach(var kv in bag)
        {
            Console.WriteLine(kv.Key + ":" + kv.Value);
        }
    }
}