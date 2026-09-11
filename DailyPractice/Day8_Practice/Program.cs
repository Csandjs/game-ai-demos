using System;

class Player
{
    public string name ;
    public int hp;
    public int attack;
    public Player (string name , int hp , int attack)
    {
        this.name = name ;
        this.hp = hp;
        this.attack = attack;
    }
    public void TakeDamage(int enemyDamage)
    {
        hp = hp - enemyDamage;
        Console.WriteLine(name + "受到" + enemyDamage + "点伤害，剩余血量：" + hp);
    }
    //受到了多少伤害，来源是谁
    public void Attack(Enemy enemy)
    {
        Console.WriteLine(this.name + "攻击" + enemy.name);
        enemy.TakeDamage(this.attack);
    }
}
class Enemy
{
    public string name;
    public int hp;
    public int attack;
    public Enemy(string name , int hp , int attack)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
    }
    public void TakeDamage (int playerDamage)
    {
        hp = hp - playerDamage;
        Console.WriteLine(name + "受到" + playerDamage + "点伤害，剩余血量" + hp);
    }
    public void Attack(Player player)
    {
        Console.WriteLine(this.name + "攻击" + player.name);
        player.TakeDamage(this.attack);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Player p1 = new Player("小明" , 100 , 10);
        // Player p2 = new Player("小红" , 100 , 15);
        // p1.Attack(p2);
        // p2.Attack(p1);
        // p1.Attack(p2);
        Player p1 = new Player("勇者" , 100 , 200);
        Enemy e1 = new Enemy("史莱姆" , 1000 , 10);
        while (true)
        {
            p1.Attack(e1);
            if(e1.hp <= 0)
            {
                Console.WriteLine("勇者获胜");
                break;
            }
            e1.Attack(p1);
            if(p1.hp <= 0)
            {
                Console.WriteLine("勇者已阵亡，游戏失败");
                break;
            }
        }
    }
}
