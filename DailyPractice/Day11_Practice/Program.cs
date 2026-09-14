using System.Collections.Generic;
abstract class Weapon
{
    protected string name;
    public Weapon(string name)
    {
        this.name = name;
    }
    public abstract void Attack();
}
class Sword : Weapon
{
    public Sword(string name) : base(name){}
    public override void Attack()
    {
        Console.WriteLine(name + " 挥砍！");
    }
}
class Bow : Weapon
{
    public Bow(string name) : base(name){}
    public override void Attack()
    {
        Console.WriteLine(name + " 拉弓射箭！");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // List<Weapon> list = new List<Weapon>();
        // list.Add(new Sword("青钢剑"));
        // list.Add(new Bow("长弓"));
        // foreach(Weapon w in list)
        // {
        //     w.Attack();
        // }
        // Console.WriteLine(list.Count);
        List<Weapon> list = new List<Weapon>();
        Weapon w ;
        Console.WriteLine("请输入你要创建的武器数量：");
        int count = int.Parse(Console.ReadLine());
        for(int i = 0; i < count ; i++)
        {
            Console.WriteLine("请输入第" + (i + 1) + "把武器的种类(Sword/Bow):");
            string kind = Console.ReadLine();
            if(kind == "Sword")
            {
                Console.WriteLine("他的名字是：");
                string nm = Console.ReadLine();
                 w = new Sword(nm);
                 list.Add(w);
            }
            if(kind == "Bow")
            {
                Console.WriteLine("他的名字是：");
                string nm = Console.ReadLine();
                w = new Bow(nm);
                list.Add(w);
            } 
        }
        foreach(Weapon h in list)
        {
                h.Attack();
        }
        Console.WriteLine(list.Count);
    }
}//以上是对昨天的回顾