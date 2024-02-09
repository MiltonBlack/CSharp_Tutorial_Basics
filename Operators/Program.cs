// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
StringEquality();
StringEqualitySpecifyingCompareRules();
StringsAreImmutable();
StringsAreImmutable2();
FunWithStringBuilder();
PrintAdd();
ProcessBytes();

static void StringEquality()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Test these strings for equality.
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
}

static void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("=> String equality (Case Insensitive:");
    string s1 = "Hello!";
    // Chapter 3 ■ Core C# Programming Constructs, Part 1
    // 87
    string s2 = "HELLO!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Check the results of changing the default compare rules.
    Console.WriteLine("Default rules: s1={0},s2={1}s1.Equals(s2): {2}", s1, s2, 
    s1.Equals(s2));
    Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2,StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();
    Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
    Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();
}

static void StringsAreImmutable()
{
 Console.WriteLine("=> Immutable Strings:\a");
 // Set initial string value.
 string s1 = "This is my string.";
 Console.WriteLine("s1 = {0}", s1);
 // Uppercase s1?
 string upperString = s1.ToUpper();
 Console.WriteLine("upperString = {0}", upperString);
 // Nope! s1 is in the same format!
 Console.WriteLine("s1 = {0}", s1);
}

static void StringsAreImmutable2()
{
 Console.WriteLine("=> Immutable Strings 2:\a");
 string s2 = "My other string";
 s2 = "New string value";
 Console.WriteLine(s2);
}

static void FunWithStringBuilder()
{
 Console.WriteLine("=> Using the StringBuilder:");

// C# v10

//  StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
//  sb.Append("\n");
//  sb.AppendLine("Half Life");
//  sb.AppendLine("Morrowind");
//  sb.AppendLine("Deus Ex" + "2");
//  sb.AppendLine("System Shock");
//  Console.WriteLine(sb.ToString());
//  sb.Replace("2", " Invisible War");
//  Console.WriteLine(sb.ToString());
//  Console.WriteLine("sb has {0} chars.", sb.Length);
//  Console.WriteLine();

// Make a StringBuilder with an initial size of 256.
// StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);
}

static void PrintAdd()
{
 // Add two shorts and print the result.
short numb1 = 9, numb2 = 10;
Console.WriteLine("{0} + {1} = {2}",
 numb1, numb2, Add(numb1, numb2));
Console.ReadLine();
}
static int Add(int x, int y)
{
 return x + y;
}

static void ProcessBytes()
{
 byte b1 = 100;
 byte b2 = 250;
 byte sum = (byte)Add(b1, b2);
 // sum should hold the value 350. However, we find the value 94!
 Console.WriteLine("sum = {0}", sum);

  try
 {
 sum = checked((byte)Add(b1, b2));
 Console.WriteLine("sum = {0}", sum);
 }
 catch (OverflowException ex)
 {
 Console.WriteLine(ex.Message);
 }
}