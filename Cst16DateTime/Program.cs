using System.Diagnostics;

/*
DateTime n = DateTime.Now;
Console.WriteLine(n.ToString());
Console.WriteLine(n.Year);
Console.WriteLine(n.Month);
Console.WriteLine(n.Day);
Console.WriteLine(n.Hour);
Console.WriteLine(n.Minute);
Console.WriteLine(n.Second);
Console.WriteLine(n.Millisecond); 
Console.WriteLine(n.Ticks);
Console.WriteLine(n.DayOfYear);
Console.WriteLine(n.DayOfWeek);
DateTime m = DateTime.UtcNow;
Console.WriteLine(m.ToString());
Console.WriteLine(m.Ticks);
DateTime x = new DateTime(2023,1,1,0,0,1);
Console.WriteLine(x.ToString());
var l = n - x;
Console.WriteLine(l.ToString());
Console.WriteLine(l.TotalSeconds);
var y = n.AddDays(2);
Console.WriteLine(y.ToString());
var z = n + l;
Console.WriteLine(z.ToString());
Console.WriteLine(n.ToShortTimeString());
Console.WriteLine(n.ToLongDateString());
Console.WriteLine(n.ToString("MM/dd/yyyy"));
*/
/*
DateTime t = DateTime.Parse(Console.ReadLine());
Console.WriteLine(t.ToString());
string s = Console.ReadLine();
DateTime u = DateTime.ParseExact(s, "mm/dd/yyyy", null);
Console.WriteLine(u.ToString());
*/
/*
var start = Stopwatch.StartNew();
for (int i = 0; i < 10000; i++)
{
    Console.WriteLine(i.ToString());
}
Console.WriteLine(start.ElapsedMilliseconds);
*/
var sw = Stopwatch.StartNew();
await Task.Delay(1000);
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);