using Cst12CollList;
using System.Collections;

ArrayList al = new ArrayList();
al.Add(1);
al.Add("Ahoj");
al.Add(new Student { Firstname = "Alois" });
al.Add(new Student { Firstname = "Bořivoj" });
al.Add(new Student { Firstname = "Ctirad" });
foreach (var x in al)
{
    if (x is Student)
    {
        Console.WriteLine((x as Student).Firstname);
    } 
}

List<int> cisla = new List<int>();
cisla.Add(1);
cisla.Add(2);
cisla.Add(3);
cisla.Add(5);
cisla.Add(6);
cisla.Add(9);
cisla.Insert(0,8);
cisla[2] = 8;
cisla.Remove(2);
cisla.RemoveAt(3);
foreach(var x in cisla)
{
    Console.WriteLine(x);
}
var r = new Repository<int>();

Dictionary<string, string> slovicka = new Dictionary<string, string>();
slovicka.Add("pes","dog");
slovicka.Add("kočka", "cat");
slovicka.Add("myš", "mouse");
Console.WriteLine(slovicka["pes"]);
if (slovicka.ContainsKey("antilopa"))
{
    Console.WriteLine(slovicka["antilopa"]); // exception
}
else
{
    Console.WriteLine("--");
}
//slovicka.Add("kočka", "kitty");
slovicka["kočka"] = "kitty";
slovicka.Remove("myš");
foreach(var x in slovicka)
{
    Console.WriteLine(x.Key + ":" + x.Value);
}