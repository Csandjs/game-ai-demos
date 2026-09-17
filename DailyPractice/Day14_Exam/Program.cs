interface IDamageable
{
    void TakeDamage(int damage);
}
class Character:IDamageable
{
    public string Name
    {
        get;
        private set;
    }
    public int Hp
    {
        get;
        private set;
    }
    public int ATk
    {
        get;
        private set;
    }
    public Character(string name , int hp, int atk)
    {
        Name = name;
        Hp =hp;
        ATk = atk;
    }
    public bool IsDead
    {
        get {return Hp <= 0;}
    }
    public void TakeDamage(int damage)
    {
        Hp = Hp - damage;
        if(Hp < 0) Hp = 0;
        Console.WriteLine(Name + "受到：" + damage + "点伤害，剩余血量：" + Hp);
    }
    public  virtual void Attack(Character target)
    {
        Console.WriteLine(Name + "攻击" + target.Name);
    }
}
class Player : Character
{
    public Player(string name, int hp,int atk) : base(name, hp,atk){}
    public override void Attack(Character target)
    {
        Console.WriteLine(Name + "挥砍" + target.Name);
        target.TakeDamage(ATk);
    }
}
class Enemy : Character
{
    public Enemy(string name, int hp , int atk) : base (name,hp,atk){}
    public override void Attack(Character target)
    {
        Console.WriteLine(Name + "扑咬" + target.Name);
        target.TakeDamage(ATk);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Character p = new Player("勇者", 100, 15);
        Character e = new Enemy("史莱姆" , 50, 8);
        while (!p.IsDead && !e.IsDead)
        {
            p.Attack(e);
            if(e.IsDead)
            {
                Console.WriteLine("勇者获胜，游戏胜利");
                break;
            }
            e.Attack(p);
            if(p.IsDead)
            {
                Console.WriteLine("勇者阵亡，游戏失败");
                break;
            }
        }
    }
}