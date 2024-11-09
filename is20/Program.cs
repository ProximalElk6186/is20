internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length == 0 || args.Length > 1)
        {
            Console.WriteLine("Usage: [number]");
        }
        else if (args.Length == 1)
        {
            Console.WriteLine(isNumber20(args[0]).ToString());
        }
    }
    public static bool isNumber20(string no) 
    {
        switch (no) 
        {
            default:
                return false;
            case "20":
                return true;
        }
    }
}