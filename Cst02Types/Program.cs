/*
 * Hodnotové typy 
 */

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types

// implicitní přetypování
float a = 10f;
double b = a;
Console.WriteLine(b);

// explicitní přetypování
double c = 10;
float d = (float)c;

int e = 5;
double f = e;

double g = 5.4;
int h = (int)g;
Console.WriteLine(h);

// konverze
string i = "Veverka";
int j;
bool ok = int.TryParse(i, out j);
Console.WriteLine(j);

//int k = int.Parse(i);
//Console.WriteLine(k);

//int l = Convert.ToInt32(i);
//Console.WriteLine(l);

// camelCase - proměnné
// PascalCase - funkce a metody
// under_line - //
// UPPER_CASE - důležité konstanty