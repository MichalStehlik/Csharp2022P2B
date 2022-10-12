/*
var y = .8f;
var e = 0;
while (y > .1)
{
    y /= 2;
    //Console.WriteLine(y + " " + e);
    e += 10;
}
Console.WriteLine(e);
*/
// --Pole
/*
int[] cisla1;
int[] cisla2 = new int[3];
cisla2[0] = 1;
cisla2[1] = 2;
cisla2[2] = 3;
//cisla2[3] = 4;
//int[] cisla3 = new int[] { 1,2,3};
int[] cisla3 = { 1, 2, 3, 4 };
Console.WriteLine(cisla3);
for(int i = 0; i < cisla3.Length; i++)
{
    Console.WriteLine(i + " " + cisla3[i]);
}
var q = 0;
foreach(int x in cisla3)
{
    Console.WriteLine(q++ + " " + x);
}
*/
/*
int[] prvni = { 0, 1, 2, 3 };
int[] druhe = prvni;
druhe[0] = 1000;
foreach (var x in prvni)
{
    Console.WriteLine(x);
}
*/
/*
int[,] sachovnice = new int[2, 3]
    {
        { 0,1},{ 2,3},{ 4,5}
    }; 
Console.WriteLine(sachovnice);
foreach(var x in sachovnice)
{
    Console.WriteLine(x);
}
Console.WriteLine(sachovnice.Length);
Console.WriteLine(sachovnice.Rank);
var sirka = sachovnice.GetLength(0);
var delka = sachovnice.GetLength(1);
for(int i = 0; i < sirka; i++)
{
    for (int j = 0; j < delka; j++)
    {
        Console.Write(sachovnice[i,j]);
    }
    Console.WriteLine();
}
*/
/*
int[][] zubate = new int[3][];
zubate[0] = new int[] { 0, 1, 2 };
zubate[1] = new int[] { 3, 4 };
zubate[2] = new int[] { 5, 6, 7, 8 };
foreach(var x in zubate)
{
    foreach(var y in x)
    {
        Console.Write(y);
    }
    Console.WriteLine();
}
*/
int[] znamky = new int[100];
Console.WriteLine(znamky[0]);
znamky[0] = 1;
znamky[1] = 1;
znamky[2] = 4;
znamky[3] = 5;
int pocet = 4;
foreach (int x in znamky)
{
    Console.Write(x);
}
Console.WriteLine();
for (int i = 0; i < pocet; i++)
{
    Console.Write(znamky[i]);
}
Console.WriteLine();