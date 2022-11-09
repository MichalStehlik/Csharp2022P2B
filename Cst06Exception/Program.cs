// See https://aka.ms/new-console-template for more information
using Cst06Exception;

ErrorMaker em = new ErrorMaker(10);
em.AddValue(10);
Console.WriteLine(em.Value);
int x = 0;
em.AddValue2(10, out x);
try
{
    em.AddValue4(0);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Argument: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Jiná chyba: " + ex.Message);
}
Console.WriteLine(em.Value);