using System;
using System.Collections.Generic;

interface IInteractable
{
    bool Interact();
}
class Door : IInteractable
{
    public bool Interact()
    {
        Console.WriteLine("门被打开了");
        return true;
    }
}
class Chest : IInteractable
{
    private bool isOpened = false;
    public bool Interact()
    {
        if(!isOpened)
        {
            Console.WriteLine("宝箱打开，获得100金币");
            isOpened = true;
            return true;
        }
        else
        {
            Console.WriteLine("宝箱已经是空的了");
            return false;
        }
    }
}
class Npc : IInteractable
{
    public bool Interact()
    {
        Console.WriteLine("NPC:勇者，你好啊！");
        return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<IInteractable> interactables = new List<IInteractable>
        {
            new Door(),
            new Chest(),
            new Npc()
        };
        foreach(IInteractable item in interactables)
        {
            bool success = item.Interact();
            if (success)
            {
                Console.WriteLine("交互成功");
            }
            else Console.WriteLine("交互失败");
        }
        bool succes = interactables[1].Interact();
        if (succes)
            {
                Console.WriteLine("交互成功");
            }
            else Console.WriteLine("交互失败");
    }
}