class UIManager
{
    private static UIManager instance = new UIManager();
    public static UIManager Instance
    {
        get {return instance;}
    }
    private UIManager(){}
    public int CanvasCount = 2;
}
class Program
{
    static void Main(string[] args)
    {
        UIManager u1 = UIManager.Instance;
        UIManager u2 = UIManager.Instance;
        Console.WriteLine(u1 == u2);
        Console.WriteLine(u1.CanvasCount);
        Console.WriteLine(UIManager.Instance.CanvasCount);
    }
}