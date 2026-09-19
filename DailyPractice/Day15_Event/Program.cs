class Player
{
    public event Action<int> ? OnDamage;
    public int Hp = 100;
    public void TakeDamage(int damage)
    {
        Hp = Hp - damage;
        Console.WriteLine("受到" + damage + "点伤害，剩余血量：" + Hp);
        OnDamage?.Invoke(Hp);
    }
}
class UIManager
{
    public void HpUI(int hp)
    {
        Console.WriteLine("【UI】血条刷新，当前血量：" + hp);
    }
}
class AuaioManager
{
    public void PlayHurtSound(int hp)
    {
        Console.WriteLine("受伤惨叫");
    }
}
class AchievementSystem
{
    public void CheckAchievement(int hp)
    {
        if(hp < 30)
        Console.WriteLine("【成就】残血！解锁残血反杀条件");
        else
        Console.WriteLine("【成就】血量还健康，继续观察");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        UIManager ui = new UIManager();
        AuaioManager auaio = new AuaioManager();
        AchievementSystem achievement = new AchievementSystem();
        player.OnDamage += ui.HpUI;
        player.OnDamage += auaio.PlayHurtSound;
        player.OnDamage += achievement.CheckAchievement;
        player.TakeDamage(20);
        player.TakeDamage(70);
    }
}
