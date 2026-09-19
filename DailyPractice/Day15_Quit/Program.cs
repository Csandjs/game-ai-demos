class Game
{
    public event Action ? OnQuit;
    public void Run()
    {
        while (true)
        {
            Console.WriteLine("游戏运行中，按Q退出");
            ConsoleKey Key = Console.ReadKey(true).Key;
            if(Key == ConsoleKey.Q)
            {
                OnQuit?.Invoke();
                break;
            }
        }
        Console.WriteLine("游戏结束");
    }
}
class SaveSystem
{
    public void AutoSave()
    {
        Console.WriteLine("自动存档中");
    }
}
class UIManager
{
    public void CloseAll()
    {
        Console.WriteLine("关闭所有菜单");
    }
}
class AudioManager
{
    public void StopMusic()
    {
        Console.WriteLine("停止背景音乐");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        SaveSystem save = new SaveSystem();
        UIManager uIManager = new UIManager();
        AudioManager audioManager = new AudioManager();
        game.OnQuit += save.AutoSave;
        game.OnQuit += uIManager.CloseAll;
        game.OnQuit += audioManager.StopMusic;
        game.Run();
    }
}