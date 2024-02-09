// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ForLoopExample();
ForeachLoop();
LinqQueryOverInts();
WhileLoopExample();
DoWhileLoopExample();


static void ForLoopExample() {
    Console.WriteLine("_____ For Loop _____");
    for(int i = 0; i < 6; i++) {
        Console.WriteLine("Number is: {0}", i);
    }
    // No Scope, just a single line and it worked "only in a single line i repeat!!!"
    for(int i = 0; i < 4; i++) Console.WriteLine("Number is: {0} ", i);
    Console.WriteLine();
}

static void ForeachLoop() {
    Console.WriteLine("_____ ForEach Loop _____");
    string[] carBrands = {"Aston Martin", "BMW", "Honda", "GMC", "Cadilac", "Chevrolet", "Ford", "Toyota"};
    foreach (string b in carBrands) {
        Console.WriteLine(b);
    }
    int[] myInts = {10, 20, 30, 40, 60};
    foreach (int i in myInts)
    {
        Console.WriteLine(i);
    }
        Console.WriteLine();
}

static void LinqQueryOverInts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
    // LINQ query!
    var subset = from i in numbers where i < 10 select i;
    Console.Write("Values in subset: ");
    foreach (var i in subset)
    {
    Console.Write("{0} ", i);
    }
}

static void WhileLoopExample()
{
    string userIsDone = "";
    while (userIsDone.ToLower() != "yes")
    {
        Console.WriteLine("in a While Loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
    }
        Console.WriteLine();
}

static void DoWhileLoopExample()
{
    string userIsDone = "";
    do
    {
    Console.WriteLine("In do/while loop");
    Console.Write("Are you done? [yes] [no]: ");
    userIsDone = Console.ReadLine();
    } while (userIsDone.ToLower() != "yes"); 
    // Note the semicolon!
}