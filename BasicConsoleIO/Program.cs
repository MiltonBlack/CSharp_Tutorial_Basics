// See https://aka.ms/new-console-template for more information
Console.WriteLine("************ Basic Console I/O ****************");
GetUserData();
FormatNumericalData();
Console.ReadLine();
static void GetUserData()
{
    // Get name and Age
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    Console.Write("Please enter your age: ");
    string userAge = Console.ReadLine();

    // Change echo color, just for fun
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    // Echo to the console
    Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

    // Restore Previous Color
    Console.ForegroundColor = prevColor;
}
static void FormatNumericalData()
{
    Console.WriteLine("The value 666666 in various formats:");
    Console.WriteLine("c format: {0:c}", 666666);
    Console.WriteLine("d8 format: {0:d8}", 666666);
    Console.WriteLine("f3 format: {0:f3}", 666666);
    Console.WriteLine("n format: {0:n}", 666666);
    Console.WriteLine("E format: {0:E}", 666666);
    Console.WriteLine("e format: {0:e}", 666666);
    Console.WriteLine("X format: {0:X}", 666666);
    Console.WriteLine("x format: {0:x}", 666666);
}