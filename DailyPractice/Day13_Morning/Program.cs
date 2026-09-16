class Character
{
    //private int hp;
    //private string name;
    public static int count = 0;
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
    public Character(string name, int hp)
    {
        Name = name;
        Hp = hp;
        count++;
    }
    // public Character(string name, int hp)
    // {
    //     this.name = name;
    //     this.hp = hp;
    //     count++;
    // }
    // public string Name
    // {
    //     get { return name;}
    // }
    // public int Hp
    // {
    //     get {return hp;}
    // }
    public bool IsDead
    {
        get{return Hp <= 0;}
    }
    public void Takedamage(int damage)
    {
        Hp -= damage;
        Console.WriteLine(Name + "受到" + damage + "点伤害，剩余血量：" + Hp);
    }
    public virtual void Attack(Character target)
    {
        Console.WriteLine(Name + "攻击" + target.Name);
        target.Takedamage(10);
    }
}
class Player : Character
{
    public Player(string name, int hp) : base(name, hp){}
    public override void Attack(Character target)
    {
        Console.WriteLine(Name + "挥砍" + target.Name);
        target.Takedamage(15);
    }
}
class Enemy : Character
{
    public Enemy(string name, int hp) : base(name, hp){}
    public override void Attack(Character target)
    {
        Console.WriteLine(Name + "扑咬" + target.Name);
        target.Takedamage(8);
    }
}
class CharacterFactory
{
    public Character Create(string type)
    {
        if (type == "player") return new Player("勇者",100);
        else if(type == "enemy") return new Enemy("史莱姆", 50);
        else
        {
            Console.WriteLine("没有这种类型的角色：" + type);
            return null;
        }
    }
}
enum GameState
{
    Menu,
    Playing,
    Paused,
    Win
}
class Program
{
    static void Main(string[] args)
    {
        // CharacterFactory factory = new CharacterFactory();
        // string[] types = {"player", "enemy", "enemy"};
        // List<Character> characters = new List<Character>();
        // Character role;
        // Character e = new Enemy("史莱姆" , 50);
        // while (!e.IsDead)
        // {
        //     e.Takedamage(10);
        //     Console.WriteLine(e.Hp);
        //     Console.WriteLine("死掉了吗：" + e.IsDead);
        // }
        // foreach(string s in types)
        // {
        //     role = factory.Create(s);
        //     if(role != null)
        //     {
        //         characters.Add(role);
        //     }
        // }
        // foreach(Character character in characters)
        // {
        //     Console.WriteLine(character.Name + " \t血量：" + character.Hp);
        // }
        // Console.WriteLine("当前角色总数：" + Character.count);
        GameState state = GameState.Menu;
        bool running = true;
        while (running)
        {
            switch (state)
            {
                case GameState.Menu : 
                Console.WriteLine("按回车开始游戏");
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Enter)
                    {
                        state = GameState.Playing;
                    }
                break;
                case GameState.Playing :
                Console.WriteLine("游戏中：按P暂停，按W直接通关");
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.P)
                    {
                        state = GameState.Paused;
                    }
                else if(input.Key == ConsoleKey.W)
                    {
                        state = GameState.Win;
                    }
                break;
                case GameState.Paused :
                Console.WriteLine("已暂停：按P继续");
                input = Console.ReadKey(true);
                if(input.Key == ConsoleKey.P)
                    {
                        state = GameState.Playing;
                    }
                break;
                case GameState.Win :
                Console.WriteLine("游戏胜利！按Q退出");
                input = Console.ReadKey(true);
                if(input.Key == ConsoleKey.Q)
                    {
                        running = false;
                    }
                break;
            }
        }
        Console.WriteLine("游戏已结束");
    }
}