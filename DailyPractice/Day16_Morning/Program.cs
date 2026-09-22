using System;

class DoorBell
{
    public event Action ? OnBell;
    public void Ring()
    {
        Console.WriteLine("门铃响了！");
        OnBell?.Invoke();
    }
}
class LampManager
{
    public void Openlamp()
    {
        Console.WriteLine("客厅灯亮了");
    }
}
class Dog
{
    public void Shout()
    {
        Console.WriteLine("汪汪汪");
    }
}
class Program
{
    static void Main(string[] args)
    {
        DoorBell door = new DoorBell();
        LampManager lamp = new LampManager();
        Dog dog = new Dog();
        door.OnBell += lamp.Openlamp;
        door.OnBell += dog.Shout;
        door.Ring();
    }
}