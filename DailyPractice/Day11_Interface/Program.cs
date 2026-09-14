using System;
using System.Data;
using System.Runtime.InteropServices;
interface IMovable
{
    void Move();
}
interface IDamageable
{
    void TakeDamage(int damage);
}
class Player : IMovable , IDamageable
{
    public int hp = 100;
    public void Move()
    {
        Console.WriteLine("玩家在地上奔跑");
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        Console.WriteLine("玩家受到" + damage + "点伤害，剩余血量：" + hp);
    }
}
class Enemy : IMovable
{
    public void Move()
    {
        Console.WriteLine("敌人朝玩家缓慢逼近");
    }
}
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("汽车在公路上飞驰");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("接口定义成功！");
        Player p = new Player();
        p.Move();
        p.TakeDamage(20);
        IMovable[] movers = new IMovable[]
        {
            new Player(),
            new Enemy(),
            new Car()
        };
        foreach(IMovable m in movers)
        {
          m.Move();  
        }
    }
}