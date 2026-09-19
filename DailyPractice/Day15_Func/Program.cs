class Weapon
{
    public string name;
    public Func<int, int, int> ? damageFormula;
    public Weapon(string name, Func<int, int, int> formula)
    {
        this.name = name;
        damageFormula = formula;
    }
    public void Attack(int attack, int defense)
    {
        int damage = damageFormula(attack, defense);
        Console.WriteLine(name + "造成了" + damage + "点伤害");
    }
}
class Program
{
    // 三种公式：签名都是"两个 int 进、一个 int 出"，正好匹配插槽
    static int Normal(int attack, int defense)        { return attack + 10; }
    static int Critical(int attack, int defense)      { return attack * 2; }
    static int ArmorPiercing(int attack, int defense) { return attack - defense / 2; }

    static void Main(string[] args)
    {
        Weapon sword = new Weapon("普通剑", Normal);
        Weapon dagger = new Weapon("暴击匕首", Critical);
        Weapon bow = new Weapon("穿甲弓", ArmorPiercing);

        sword.Attack(30, 20);    // 同样 30 攻 20 防
        dagger.Attack(30, 20);
        bow.Attack(30, 20);
    }
}