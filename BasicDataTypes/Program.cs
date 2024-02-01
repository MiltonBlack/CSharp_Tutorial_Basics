// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("****** Fun with Basic Data Types ******");

LocalVarDeclaration();
DefaultDeclarations();
NewingDataTypes();
NewingDataTypesShort();
ObjectFunctionality();
DataTypeFunc();
ParseDataFromStrings();
ParseFromStringWithTryParse();

static void LocalVarDeclaration()
{
    Console.WriteLine("=> Data Declarations:");
    // Local Variables as so:
    // dataType varName

    int myInt = 1;
    string myString;
    myString = "This is my first time!!!";

    // declare 3 bools on a single line
    bool b1 = true, b2 = false, b3 = b1;

    System.Boolean b4 = false;
    
    Console.WriteLine("Your Data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
    Console.WriteLine();
}

static void DefaultDeclarations()
{
    Console.WriteLine("=> Default Declarations:");
    int myInt = default;
    Console.WriteLine(myInt);
}

static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool(); // default to false
    int i = new int(); // default to 0
    double d = new double(); // defaults to 0.0
    DateTime dt = new DateTime(); // defaults to "1/1/0001 12:00:00 AM"
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

static void NewingDataTypesShort()
{
    Console.WriteLine("=> Using new short-cut to create variables:");
    bool b = new();
    int i = new();
    double d = new();
    DateTime dt = new();
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

static void ObjectFunctionality() {
Console.WriteLine("=> System.Object Functionality");

    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Equals(25) = {0}", 12.Equals(25));
    Console.WriteLine("12.ToString() = {0}", 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();
}

static void DataTypeFunc()
{
    Console.WriteLine("=> Data Type Functionality:");

    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}", double.MaxValue);
    Console.WriteLine("Min of double: {0}", double.MinValue);
    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
    Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
    Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
    Console.WriteLine();
}

static void ParseDataFromStrings()
{
    Console.WriteLine("=> Data type parsing:");
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i);
    char c = Char.Parse("W");
    Console.WriteLine("Value of c: {0}", c);
    Console.WriteLine();
}

static void ParseFromStringWithTryParse()
{
    Console.WriteLine("=> Data type parsing with TryParse:");
    if(bool.TryParse("True", out bool b))
    {
        Console.WriteLine("Value of b: {0}", b);
    }
    else
    {
        Console.WriteLine("Default value of b: {0}", b);
    }

    string value = "Hello";
    if (double.TryParse(value, out double d))
    {
        Console.WriteLine("Value of d: {0}", d);
    }
    else {
        Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value, d);
    }
    Console.WriteLine();
}

static void UseDateAndTime(){
    Console.WriteLine("=> Dates and Time:");

    // This constructor takes (year, month, day).
}