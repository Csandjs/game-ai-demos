using System.Collections;

class Slime
{
    static public int Count
    {
        get;
        private set;
    }
    public string Name
    {
        get;
        private set;
    }
    public Slime(string name)
    {
        Name = name;
        Count++;
    }
    static public void ShowCount()
    {
        Console.WriteLine("史莱姆的数量：" + Count);
    }
}
class SaveSystem
{
    private static SaveSystem instanse = new SaveSystem();
    public static SaveSystem Instance
    {
        get {return instanse;}
    }
    private SaveSystem(){}
    public int SaveSlot = 3;
}
enum EnemyState
{
    Idle,
    Patrol,
    Chase,
    Dead
}
class Program
{
    static void Main(string[] args)
    {
        Slime slime1 = new Slime("史莱姆");
        Slime slime2 = new Slime("史莱姆");
        Slime slime3 = new Slime("史莱姆");
        Console.WriteLine(Slime.Count);
        Slime.ShowCount();
        EnemyState[] states = {EnemyState.Idle, EnemyState.Patrol, EnemyState.Chase, EnemyState.Dead};
        for(int i = 0 ;i < states.Length; i++)
        {
            switch (states[i])
            {
                case EnemyState.Idle:
                Console.WriteLine("史莱姆正在闲逛");
                break;
                case EnemyState.Patrol:
                Console.WriteLine("史莱姆正在巡逻");
                break;
                case EnemyState.Chase:
                Console.WriteLine("史莱姆正在追击玩家");
                break;
                case EnemyState.Dead:
                Console.WriteLine("史莱姆被玩家击杀了");
                break;
                default:
                break;
            }
        }
        SaveSystem s1 = SaveSystem.Instance;
        SaveSystem s2 = SaveSystem.Instance;
        Console.WriteLine(s1 == s2);
        Console.WriteLine(s1.SaveSlot);
    }
}