using Cst12CollList;

List<int> cisla = new List<int>();
cisla.Add(1);
cisla.Add(2);
cisla.Add(3);
cisla.Add(5);
cisla.Add(6);
cisla.Add(9);
cisla[2] = 8;
cisla.Remove(2);
cisla.RemoveAt(3);
foreach(var x in cisla)
{
    Console.WriteLine(x);
}
var r = new Repository<int>();