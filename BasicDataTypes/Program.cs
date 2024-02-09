// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Text;

Console.WriteLine("****** Fun with Basic Data Types ******");

LocalVarDeclaration();
DefaultDeclarations();
NewingDataTypes();
NewingDataTypesShort();
ObjectFunctionality();
DataTypeFunc();
ParseDataFromStrings();
ParseFromStringWithTryParse();
UseDateAndTime();
UseBigInteger();
DigitSeperators();
// BinaryLiterals();
BasicStringFunctionality();
StringConcatenation();
EspaceChars();
StringInterpolation();
StringInterpolationWithDefaultInterpolatedStringHandler();

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
    DateTime dt = new DateTime(2024, 1, 31);

    // What day of the month is this?
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

    // Month is now March
    dt = dt.AddMonths(2);
    Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

    // This Constructor takes (hours, minutes, seconds).
    TimeSpan ts = new TimeSpan(3, 30, 0);
    Console.WriteLine(ts);

    // Substract 15 Minutes from the current Timespan and print the result.
    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

    DateOnly d = new DateOnly(2024, 02, 01);
    Console.WriteLine(d);

    TimeOnly t = new TimeOnly(13, 30, 0, 0);
    Console.WriteLine(t);
}

static void UseBigInteger()
{
    Console.WriteLine("=> Use BigInteger:");
    BigInteger biggy = BigInteger.Parse("8908908908909890890890890890890890890");
    Console.WriteLine("Value of biggy is {0}", biggy);
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
    Console.WriteLine("Is biggy a Power of Two?: {0}", biggy.IsPowerOfTwo);

    BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("2525252"));
    Console.WriteLine("Value of reallyBig is {0}", reallyBig);
}

static void DigitSeperators()
{
    Console.WriteLine("=> Use Digit Seperators:");
    Console.WriteLine("Integer");
    Console.WriteLine(123_456);
    Console.WriteLine("Long:");
    Console.WriteLine(123_456_789L);
    Console.WriteLine("Float:");
    Console.WriteLine(123_456.1234F);
    Console.WriteLine("Double:");
    Console.WriteLine(123_456.12M);

    // IN v7.2, Hex can begin with _
    Console.WriteLine("Hex:");
    Console.WriteLine(0x_00_00_FF);
}

static void BinaryLiterals() {
    // in v7.2 Binary can begin with _
    Console.WriteLine("=> Use Binary Literals:");
    // Console.WriteLine("Four: {0}", ob_0000_0100);
    // Console.WriteLine("Sixteen: {0}", ob_0001_0000);
    // Console.WriteLine("Thirty Two: {0}", ob_0010_0000);
    // Console.WriteLine("Sixty Four: {0}", ob_0100_0000);
}

static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String functionality:");
    string firstName = "Freddy";
    Console.WriteLine("Value of FirstName {0}", firstName);
    Console.WriteLine("FirstName has {0} Characters.", firstName.Length);
    Console.WriteLine("FirstName in Uppercase: {0}.", firstName.ToUpper());
    Console.WriteLine("FirstName in Lowercase: {0}.", firstName.ToLower());
    Console.WriteLine("FirstName contains the letter y?: {0}.", firstName.Contains("y"));
    Console.WriteLine("New FirstName: {0}.", firstName.Replace("dy", ""));
    Console.WriteLine();
}

static void StringConcatenation()
{
    Console.WriteLine("=> String concatenation:");
    string s1 = "Programming the ";
    string s2 = "PhyscoDrill (PTP)";
    string s4 = "Milton ";
    string s5 = "Black";
    string s6 = s4 + s5;
    string s3 = String.Concat(s1, s2);
    Console.WriteLine(s3);
    Console.WriteLine(s6);
    Console.WriteLine();
}

static void EspaceChars()
{
    Console.WriteLine("=> Escape Characters:");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name";
    Console.WriteLine(strWithTabs);

    Console.WriteLine("Everyone loves \"Hello World!\"");
    Console.WriteLine("D:\\Development\\CSharp\\BasicConsoleIO ");

    // Adds a total of 4 blank lines (3 escaped, 1 from WriteLine).
    Console.WriteLine("All finished.\n\n\n ");
    Console.WriteLine();

    // Adds a 4 more blank lines.
    Console.WriteLine("All finished for real this time. {0}{0}{0}", Environment.NewLine);
}

static void StringInterpolation()
{
 Console.WriteLine("=> String interpolation:\a");

 // Some local variables we will plug into our larger string
 int age = 4;
 string name = "Milton";

 // Using curly-bracket syntax.
 string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
 Console.WriteLine(greeting);

 // Using string interpolation
 string greeting2 = $"\tHello {name.ToUpper()} you are {age} years old.";
 Console.WriteLine(greeting2);
}

static void StringInterpolationWithDefaultInterpolatedStringHandler()
{
 Console.WriteLine("=> String interpolation under the covers:\a (C# v10)");
 int age = 4;
 string name = "Soren";
//  var builder = new DefaultInterpolatedStringHandler(3,2);
//  builder.AppendLiteral("\tHello ");
//  builder.AppendFormatted(name);
//  builder.AppendLiteral(" you are ");
//  builder.AppendFormatted(age);
//  builder.AppendLiteral(" years old.");
//  var greeting = builder.ToStringAndClear();
//  Console.WriteLine(greeting);

// The following string is printed verbatim,
// thus all escape characters are displayed.
// Console.WriteLine(@"C:\MyApp\bin\Debug");

// Whitespace is preserved with verbatim strings.
// string myLongString = @"This is a very
//  very
//  very
//  long string";
// Console.WriteLine(myLongString);
}