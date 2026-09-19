// using System;
// delegate void Notify();
// class Program
// {
//     static void SayHello()
//     {
//         Console.WriteLine("你好！！");
//     }
//     static void SayBye()
//     {
//         Console.WriteLine("再见！");
//     }
//     static void Main(string[] args)
//     {
//         Notify n = SayHello;
//         n();
//         n = SayBye;
//         n();
//         SayBye();
//         SayHello();
//     }
// }

class Button
{
    public event Action OnClick;
    public void Click()
    {
        if(OnClick != null)
        {
            OnClick();
        }
    }
}
class Program
{
    static void SayHello()
    {
        Console.WriteLine("打招呼：你好！");
    }
    static void OpenDoor()
    {
        Console.WriteLine("开门：嘎吱——门开了");
    }
    static void PlaySound()
    {
        Console.WriteLine("播音效：叮！");
    }
    static void Main(string[] args)
    {
        Button b = new Button();
        b.OnClick += OpenDoor;
        b.OnClick += PlaySound;
        b.OnClick += SayHello;
        b.Click();
        Console.WriteLine("----摘掉音效后----");
        b.OnClick -= PlaySound;
        b.Click();
    }
}