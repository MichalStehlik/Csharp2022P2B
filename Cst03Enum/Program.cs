// enum

using System.Text;

Color bg = Color.Red;
Console.WriteLine(bg);
Console.WriteLine((int)bg);
Gender tonda = Gender.Male;
Console.WriteLine(tonda);
Console.WriteLine((int)tonda);

// operátory
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
// unární
// -1, !x
// binární
// a + b, a && c
// ternární
int a = 0;
int c = 10;
Console.WriteLine(a == 0 ? "Nic" : "Něco");
int b = a * c + ((a > 0) ? a : c + 4);
Console.WriteLine(b);
// preincrement ++a - zvysi pak vrati zvysenou
// postincrement a++ - vrati pak zvysi
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
a += 10; // a = a + 10;
// +=, -=, *=, /=, &=, ...

// Null Coalesce
StringBuilder sb = null;
sb?.Append("A");
sb?.Append('A');
Console.WriteLine(sb.ToString());

// Null varables
//int x = null;
int? x = null;

string s = "A";
s = s + "AA";

enum Color
{
    Red,
    Green,
    Blue,
    Orange,
    White,
    Black
}

enum Gender
{
    Male = 1,
    Female = 2,
    Unknown = 0,
    Other = 3
}