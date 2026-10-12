enum EnemyType{Normal , Elite , Boss}
interface IDamageable
{
    void TakeDamage(float damage);
}
static class GameConfig
{
    static private Dictionary<string, float> config = new Dictionary<string, float>
    {
        {"attack", 20f} , {"recover", 10f}, {"Normal", 10f}, {"Elite", 30f} ,{"Boss",100f}
    };
    static public float Get(string itemName)
    {
        if(config.TryGetValue(itemName, out float value))
        {
            return value;
        }
        else
        {
            Console.WriteLine("缺少配置，返回默认值：");
            return 0;
        }
    }
}
class Character : IDamageable
{
    public string Name
    {
        get;
        private set;
    }
    public float Hp
    {
        get;
        protected set;
    }
    public Character(string name, float hp)
    {
        Name = name;
        Hp = hp;
    }
    public bool IsDead => Hp <= 0;
    public virtual void TakeDamage(float damage)
    {
        Hp -= damage;
        if(Hp <= 0) Hp = 0;
        Console.WriteLine(Name + "受到" + damage + "点伤害，剩余血量：" + Hp);
    }
}
class Player : Character
{
    public Player(string name, float hp) : base(name, hp){}
    public float Atk => GameConfig.Get("attack");
    public Func<float,float> normalFormula = atk => atk;
    public Func<float,float> critFormula = atk => atk * 2;
    public void Heal()
    {
        Hp = Hp + GameConfig.Get("recover");
        if (Hp >= 100)
        {
            Hp = 100;
            Console.WriteLine("回复血量，血量已满，当前血量：" + Hp);
        }
        else
        {
            Console.WriteLine("回复10点血量,当前血量：" + Hp);
        }
    }
    public void Attack(Character other, Func<float, float> formula)
    {
        float damage = formula(Atk);
        Console.WriteLine(Name + "攻击" + other.Name);
        other.TakeDamage(damage);
    }
}
class Enemy : Character
{
    public EnemyType Type{get;}
    public float Bounty => GameConfig.Get(Type.ToString());
    public Enemy(string name, float hp, EnemyType type):base(name,hp)
    {
        Type = type;
    }
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        switch (Type)
        {
            case EnemyType.Boss:
            Console.WriteLine("我们会胜利的！");
            break;
            default:
            break;
        }
    }
}
class Scorekeeper
{
    private static Scorekeeper instance = new Scorekeeper();
    public static Scorekeeper Instance => instance;
    private Scorekeeper(){}
    public int Score
    {
        get;
        private set;
    }
    public event Action<int> ? OnScoreChanged;
    public void ReportKill(float bounty)
    {
        Score += (int)bounty;
        OnScoreChanged?.Invoke(Score);
    }
}
class ScoreUI
{
    public void RefreshScore(int newScore)
    {
        Console.WriteLine("【UI】分数刷新：" + newScore);
    }
}

class Program
{
    static void AttackAll(Player p, List<Enemy> enemys, Func<float,float> formula)
    {
        List<Enemy> survive = enemys.FindAll(enemy => !enemy.IsDead);
            foreach(Enemy enemy in survive)
            {
                p.Attack(enemy,formula);
                if(enemy.IsDead)
                {
                    Scorekeeper.Instance.ReportKill(enemy.Bounty);
                    enemys.Remove(enemy);
                }
            }
    }
    static void Main(string[] args)
    {
        bool running = true;
        Player p = new Player("勇者",100);
        Enemy b = new Enemy("魔王", 150, EnemyType.Boss);
        Enemy n = new Enemy("普通怪", 80, EnemyType.Normal);
        Enemy e = new Enemy("精英怪", 120, EnemyType.Elite);
        Dictionary<string, Action> commands = new Dictionary<string, Action>();
        List<Enemy> enemys = new List<Enemy>{b, n, e};
        commands["attack"] = () => AttackAll(p,enemys,p.normalFormula);
        commands["crit"] = () => AttackAll(p, enemys, p.critFormula);
        commands["heal"] = () => p.Heal();
        commands["quit"] = () => {running = false;};
        ScoreUI uI = new ScoreUI();
        Scorekeeper.Instance.OnScoreChanged += uI.RefreshScore;
        while (running)
        {
            Console.WriteLine("请输入命令：attack / crit / heal / quit");
            string input = Console.ReadLine();
            if(commands.TryGetValue(input, out Action action))
            {
                action();
                if(enemys.Count == 0)
                {
                    Console.WriteLine("全部消灭，总分：" + Scorekeeper.Instance.Score);
                    break;
                }
            }
            else
            {
                Console.WriteLine("未知命令：" + input);
            }
        }
    }
}