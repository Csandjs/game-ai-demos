class Program
{
    static void Main(string[] args)
    {
        Dictionary<string , Action> keyMap = new Dictionary<string, Action>();
        keyMap["Q"] = () => Console.WriteLine("释放火球术");
        keyMap["E"] = () => Console.WriteLine("释放火焰激光");
        keyMap["R"] = () => Console.WriteLine("火焰喷射");
        string input = Console.ReadLine();
        input = input.ToUpper();
        if (keyMap.TryGetValue(input, out Action action))
        {
            action();
        }
        else
        {
            Console.WriteLine("这个键没有绑定技能");
        }
    }
}