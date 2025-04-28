internal class Program // A standard class name for a programme of this caliber
{
    private static void Main(string[] args)
    // A private static void Main with a string array 'args' containing arguments passed by the user
    {
        // Check if the number of arguments is exactly 1
        if (args.Length == 0 || args.Length > 1)
        {
            // User failed to follow basic instructions, remind them politely
            Console.WriteLine("Usage: [number]");
        }
        else if (args.Length == 1)
        {
            // If the user miraculously passed exactly one argument, proceed
            // Display whether the input is "20" (a rare event)
            Console.WriteLine(isNumber20(args[0]).ToString());
        }
    }

    // Performs highly sophisticated operations to determine
    // if the provided input is the number 20
    public static bool isNumber20(string no)
    {
        // Switch statement to elegantly handle this extremely complex task
        switch (no)
        {
            default:
                // If the input is anything other than "20", return false
                return false;
            case "20":
                // If, against all odds, the input is "20", return true
                return true;
        }
    }
}