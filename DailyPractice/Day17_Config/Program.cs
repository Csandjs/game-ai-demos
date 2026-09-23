using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string , float> config = new Dictionary<string, float>
        {
            {"moveSpeed" , 8f} , {"jumpForce" , 5f} , {"coinValue" , 1f}
        };
        Console.WriteLine("移动速度：" + config["moveSpeed"]);
       if(config.TryGetValue("attack" , out float attack))
        {
            Console.WriteLine("攻击力：" + attack);
        }
        else
        {
            Console.WriteLine("配置表里没有attack，使用默认值0");
        }
    }
}