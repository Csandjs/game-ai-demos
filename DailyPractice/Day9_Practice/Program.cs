// class Character
// {
//     protected string name;
//     protected int hp;
//     protected int attack;
//     public Character (string name, int hp, int attack)
//     {
//         this.name = name;
//         this.hp = hp;
//         this.attack = attack;
//     }
//     public void TakeDamage(int damage, Character attacker)
//     {
//         hp = hp - damage;
//         Console.WriteLine(this.name + "受到" + attacker.name + damage + "点伤害，剩余" + hp +"血量");
//     }
//     public void Attack(Character target)
//     {
//         Console.WriteLine(this.name + "攻击" + target.name);
//         target.TakeDamage(this.attack , this);
//     }
//     public virtual void Move()
//     {
//         Console.WriteLine(name + "移动了");
//     }
// }
// class Player : Character
// {
//     public Player(string name ,int hp, int attack):base(name, hp, attack){}
//     public override void Move()
//     {
//         Console.WriteLine(name + "玩家用WASD走路");
//     }
// }
// class Enemy : Character
// {
//     public Enemy(string name, int hp, int attack):base(name , hp , attack){}
//     public override void Move()
//     {
//         Console.WriteLine(name + "敌人朝玩家慢慢巡逻过来");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Player p = new Player("勇者" , 100 ,15);
//         Enemy e = new Enemy("史莱姆" , 100 ,10);
//         p.Move();
//         e.Move();
//         p.Attack(e);
//         e.Attack(p);
//     }
// }
class Animal
{
    protected string name;
    public Animal(string name)
    {
        this.name = name;
    }
    public virtual void Speak()
    {
        Console.WriteLine(name + "发出了叫声");
    }
}
class Dog : Animal
{
    public Dog(string name):base(name){}
    public override void Speak()
    {
        Console.WriteLine(name + " 汪汪汪地叫");
    }
}
class Cat : Animal
{
    public Cat(string name):base(name){}
    public override void Speak()
    {
        Console.WriteLine(name + " 喵喵喵地叫");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Dog dog = new Dog("旺财");
        // Cat cat = new Cat("咪咪");
        // dog.Speak();
        // cat.Speak();
        Animal[] zoo = 
        {
            new Dog("旺财"),new Cat("咪咪"),new Dog("大黄")
        };
        foreach(Animal a in zoo)
        {
            a.Speak();
        }
    }
}