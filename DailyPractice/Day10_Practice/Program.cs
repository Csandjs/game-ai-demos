using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using System.Linq.Expressions;
// abstract class Shape
// {
//     protected string name;
//     public Shape(string name)
//     {
//         this.name = name;
//     }
//     public abstract void Show();//子类必须会这个动作；但是否父类bu写怎么做，强制子类自己完成
// }
// class Circle : Shape
// {
//     public Circle(string name) : base(name){}
//     public override void Show()
//     {
//         Console.WriteLine(name + "是圆形");
//     }
//     public void Roll()
//     {
//         Console.WriteLine(name + "滚了起来");
//     }
// }
// class Rectangle : Shape
// {
//     public Rectangle(string name) : base(name){}
//     public override void Show()
//     {
//         Console.WriteLine(name + "是矩形");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Shape[] shapes = {new Circle("小圆"),new Rectangle("方块")};
//         foreach(Shape s in shapes)
//         {
//             s.Show();
//             if (s is Circle c)
//             {
//                 c.Roll();
//             }
//         }
//         // Shape s = new Circle("小圆");
//         // s.Show();
//         // //s.Roll();这样会报错
//         // Circle c = new Circle("小圆2");
//         // c.Show();
//         // c.Roll();//这样才不会报错
//     }
// }以上为第10日早上学习练的代码
// abstract class Character
// {
//     protected string name;
//     protected int hp;
//     public Character(string name,int hp)
//     {
//         this.name = name;
//         this.hp = hp;
//     }
//     public abstract void Attack();
//     public void TakeDamage(int damage)
//     {
//         hp = hp - damage;
//         Console.WriteLine(name + "受到" + damage + "点伤害，剩余血量" + hp);
//     }
// }
// class Player : Character
// {
//     public Player(string name, int hp) :base(name ,hp){}
//     public override void Attack()
//     {
//         Console.WriteLine(name + "挥剑攻击！");
//     }
// }
// class Enemy : Character
// {
//     public Enemy(string name, int hp) : base(name , hp){}
//     public override void Attack()
//     {
//         Console.WriteLine(name + "扑上来撕咬！");
//     }
// }
// class Program
// {
//     static void Main(string[] asgr)
//     {
//         List<Character> list = new List<Character>();
//         list.Add(new Player("勇者" , 100));
//         list.Add(new Enemy("史莱姆" , 100));
//         list.Add(new Enemy("哥布林" , 100));
//         int n = list.Count;
//         foreach(Character c in list)
//         {
//             c.Attack();
//             c.TakeDamage(10);
//         }
//         Console.WriteLine(n);
//     }
// }以上是一个1多态练习
abstract class Animal
{
    protected string name;
    public Animal(string name)
    {
        this.name = name;
    }
    public abstract void Speak();
}
class Dog : Animal
{
    public Dog(string name) : base(name){}
    public override void Speak()
    {
        Console.WriteLine(name + "汪汪汪地叫");
    }
    public void Attack()
    {
        Console.WriteLine(name + "咬了你一口");
    }
}
class Cat : Animal
{
    public Cat(string name) : base(name){}
    public override void Speak()
    {
        Console.WriteLine(name + "喵喵喵地叫");
    }
    public void Attack()
    {
        Console.WriteLine(name + "抓了你一下");
    }
}
class Cow : Animal
{
    public Cow(string name) : base(name){}
    public override void Speak()
    {
        Console.WriteLine(name + "哞哞哞地叫");
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Animal> list = new List<Animal>{new Dog("旺财"), new Cat("咪咪"), new Cow("大黄")};
        foreach(Animal a in list)
        {
            a.Speak();
            if(a is Dog d)
            {
                d.Attack();
            }
            if(a is Cat c)
            {
                c.Attack();
            }
        }
        // Console.WriteLine(list.Count);
    //     Console.WriteLine("请输入你要创建的动物数量：");
    //     int count = int.Parse(Console.ReadLine());
    //     for (int i = 0 ; i < count ; i++)
    //     {
    //         Console.Write("第" + (i + 1) + "个动物的名字:");
    //         string nm = Console.ReadLine();
    //         list.Add(new Dog(nm));
    //     }
    //     foreach(Animal a in list)
    //     {
    //         a.Speak();
    //     }
    }
}