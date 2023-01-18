int a = 1;
int b = 2;

//Console.WriteLine(DoOperation(a,b,Subtraction));
//Console.WriteLine(DoBetterOperation(a, b, Subtraction));
//Console.WriteLine(DoBetterOperation(a, b, (i,j) => { return i + j; } )); // < ---- dulezite

List<int> pole = new List<int> { 0,1,2,5,8,3,4,7,9 };

/*List<int> pole2 = MyExtensions.BiggerThen(pole, 3);
foreach(var x in pole2)
{
    Console.WriteLine(x);
}
*/
List<int> pole2 = pole.BiggerThen(3);
foreach (var x in pole2)
{
    Console.WriteLine(x);
}

/*
class BetterList : List
{

}
*/

int DoOperation(int i, int j, NumOp operation)
{
    return operation(i, j);
}

int DoBetterOperation(int i, int j, Func<int,int,int> operation) // < ---- dulezite
{
    return operation(i, j);
}

int Addition(int x, int y)
{
    return x + y;
}

int Multiply(int x, int y)
{
    return x * y;
}

int Subtraction(int x, int y)
{
    return x - y;
}

delegate int NumOp(int a, int b);

static class MyExtensions
{
    static public List<int> BiggerThen(this List<int> source, int limit)
    {
        List<int> result = new List<int>();
        foreach (var x in source)
        {
            if (x > limit) result.Add(x);
        }
        return result;
    }
}