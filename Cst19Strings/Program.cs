using System.Text;

string s = "Ahoj, světe!";
System.String s2 = "P2B";
int i = 1;
double j = 2.22;
Console.WriteLine("Řekni " + s + " " + i + j);
Console.WriteLine(String.Format("Řekni {0} {1} {2}", s, i, j));
Console.WriteLine($"Řekni {s} {i} {j}");
s = "Nazdar";
s += " světe";
s += "!";
Console.WriteLine(s);
StringBuilder sb = new StringBuilder(s);
sb.Append(" světe");
sb.Append("!");
Console.WriteLine(sb.ToString());

foreach(char c in s)
{
    Console.WriteLine(c);
}
Console.WriteLine(s[3]);
// s[3] = 'x'; // nelze

string s1 = "Velký bílý pes.";
string s3 = String.Concat(s1, "Malý kůň.");
Console.WriteLine(s3);
s1 = s1.Replace("bílý","černý");
Console.WriteLine(s1);
s1 = s1.Remove(5,6);
Console.WriteLine(s1);
string[] slova = s1.Split(new char[] { ' ', '\t'});
foreach(var x in slova)
{
    Console.WriteLine(x);
}
Console.WriteLine(String.Join("--",slova));

Console.WriteLine();
Console.WriteLine("Ahoj, \t \n světe! Velikost monitoru je 30\".\a \ufeff");
Console.WriteLine(@"Verbatim řetězec
    může být klidně na víc řádek a nejsou
    v nich interpretovány únikové sekvence, 
    ""uvozovky"" je potřeba zdvojit.");
string source = "    I'm wider than I need to be.      ";
Console.WriteLine(source.Trim());