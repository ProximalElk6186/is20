internal class Program  // A standart class name
{
    private static void Main(string[] args)
//A private static void Main with a string array 'args' containing arguments the user passed to the programme 
    {
            // Checking if arguments quantity is exactly 1
        if (args.Length == 0 || args.Length > 1)    
        {
            // User is a dumbass, tell him this
            Console.WriteLine("Usage: [number]");   
        }
        // If user is not a dumbass... (pretty much impossible)
        else if (args.Length == 1)  

        {
            // Returns:
            // isNumber20
            // With an argument as a parameter
            // Converted to string
            Console.WriteLine(isNumber20(args[0]).ToString());
        }
    }
    // Does very hard mathematic calculations to check
    // if the number the user passed to the programme
    // as an argument is 20 or not
    public static bool isNumber20(string no)    
    {
        // Switch that actually does the shit
        // we're here for
        switch (no) 
        {
            // return "false" by default
            default:
                // returning "false" by default
                return false;
            // if the number is 20... (mostly impossible)
            case "20":
                // return "true" if the number is 20
                // (mostly impossible)
                return true;
        }
    }
}