using System.Security.Cryptography;

interface IDamageable
{
    void TakeDamage(int damage);
}
class Character : IDamageable
{
    private int hp;
    private string name;
    public string Name
    {
        get{return name;}
    }
    public int Hp
    {
        get{ return hp; }
    }
    public Character(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }
    public void TakeDamage(int damage)
    {
        hp = hp - damage;
        if (hp < 0) hp = 0;
        Console.WriteLine(name + "受到" + damage + "点伤害，剩余血量：" + hp);
    }
    public virtual void Attack(Character target)
    {
        Console.WriteLine(name + "攻击了" + target.Name);
        target.TakeDamage(10);
    }
}
class Player : Character
{
    public Player(string name, int hp) : base(name , hp){}
    public override void Attack(Character target)
    {
        Console.WriteLine(Name + "挥剑攻击" + target.Name);
        target.TakeDamage(15);
    }
}
class Boss : Character
{
    public Boss(string name, int hp) : base(name, hp){}
    public override void Attack(Character target)
    {
        Console.WriteLine(Name + "发动魔王重击！");
        target.TakeDamage(25);
    }
}
class Enemy : Character
{
    public Enemy(string name , int hp) : base(name, hp){}
    public override void Attack(Character target)
    {
        Console.WriteLine(Name + "扑上来攻击" + target.Name);
        target.TakeDamage(8);
    }
}
class CharacterFactory
{
    public Character Create(string type)
    {
        if (type == "player") return new Player("勇者", 100);
        else if (type == "enemy") return new Enemy("史莱姆",50);
        else if (type == "boss") return new Boss("魔王", 500);
        else
        {
            Console.WriteLine("没有这种角色：" + type);
            return null;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Character p = new Player("勇者",100);
        // Character e = new Enemy("史莱姆", 50);
        // while (true)
        // {
        //     p.Attack(e);
        //     if(e.Hp <= 0)
        //     {
        //         Console.WriteLine("勇者胜利");
        //         break;
        //     }
        //     e.Attack(p);
        //     if(p.Hp <= 0)
        //     {
        //         Console.WriteLine("勇者失败");
        //         break;
        //     }
        // }
        CharacterFactory factory = new CharacterFactory();
        string[] types = {"player", "enemy", "boss", "enemy", "player"};
        List<Character> list = new List<Character>();
        foreach(string c in types)
        {
            Character role = factory.Create(c);
            if(role != null)
            {
                list.Add(role);
            }
        }
        foreach(Character role in list)
        {
            Console.WriteLine(role.Name + "血量：" + role.Hp);
        }
    }
}