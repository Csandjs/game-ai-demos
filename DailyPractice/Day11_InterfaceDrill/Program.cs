using System;
using System.Collections.Generic;
interface IAttackable
{
    void Attack();
}
interface IHealable
{
    void Heal(int amount);
}
class Hero : IAttackable , IHealable
{
    public int hp = 100;
    public void Attack()
    {
        Console.WriteLine("英雄挥砍攻击！");
    }
    public void Heal(int amount)
    {
        hp = hp + amount;
        Console.WriteLine("击中，英雄回血" + amount + "，当前血量：" + hp);
    }
}
class Slime : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("史莱姆扑上来撞击！");
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<IAttackable> list = new List<IAttackable>
        {
            new Hero(),
            new Slime()
        };
        foreach(IAttackable a in list)
        {
            a.Attack();
        }
        Hero hero = new Hero();
        hero.Heal(30);
    }
}