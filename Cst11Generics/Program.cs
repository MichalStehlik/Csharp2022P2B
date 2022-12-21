// See https://aka.ms/new-console-template for more information
using Cst11Generics;

Container<Student> a = new Container<Student>(new Student { Name = "Felix" });
Console.WriteLine(a.Value.Name);
Console.WriteLine(GetTwice<Student>(new Student { Name = "José" }));

string GetTwice<T>(T data)
{
    return data.ToString() + data.ToString();
}