using Csc07Delegates;

List<int> data = new List<int> { 1, 2, 3, 5,9,4,2,8,6,7,1,0,1 };
foreach(var x in data.Selection(0,14))
{
    Console.WriteLine(x);
}