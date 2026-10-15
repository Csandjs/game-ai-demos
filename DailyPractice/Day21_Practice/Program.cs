using System.ComponentModel;

class Player
{
    private int hp = 100;
    public int maxHp = 100;
    public int Hp
    {
        get => hp;
        private set => hp = Math.Clamp(value, 0, maxHp);
    }
    public bool IsDead => hp <= 0;
    public event Action<int> ? OnHurt;
    public void TakeDamage(int damage)
    {
        if (IsDead) return;
        Hp -= damage;
        OnHurt?.Invoke(Hp);
        Console.WriteLine("受到" + damage + "点伤害，剩余血量" + Hp);
    }
}
class HpUI
{
    public void RefreshHpUI(int hp)
    {
        Console.WriteLine("UI刷新血量：" + hp);
    }
}
class HpSound
{
    public void HurtSound(int hp)
    {
        Console.WriteLine("播放受伤音效");
    }
}
class Command
{
    private static Command instance = new Command();
    public static Command Instance => instance;
    private Dictionary<string, Action> pairs = new Dictionary<string, Action>();
    private Command()
    {
        pairs["attack"] = () => Console.WriteLine("攻击");
        pairs["jump"] = () => Console.WriteLine("跳跃");
        pairs["run"] = () => Console.WriteLine("跑步");
    }
    public void Execute(string command)
    {
        if (pairs.TryGetValue(command, out Action ?action))
        {
            action();
        }
    }
    
}
class Program
{

    static void Main(string[] args)
    {
        Command.Instance.Execute("attack");
        
        
        





        
        Player p = new Player();
        HpUI hpUI = new HpUI();
        HpSound hpSound = new HpSound();
        p.OnHurt += hpUI.RefreshHpUI;
        p.OnHurt += hpSound.HurtSound;
        p.TakeDamage(10);
    }
}