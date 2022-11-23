using Cst08Polymorphism;

Human adam = new Human { Name = "Adam" };
Console.WriteLine(adam.Fullname());
Student bretislav = new Student { Name = "Bretislav", Grade = 1.3 };
Console.WriteLine(bretislav.Fullname());
Human cyril = new Student { Name = "Cyril", Grade = 2 };
Console.WriteLine(cyril.Fullname());
Teacher daniel = new Teacher { Name = "Daniel", Shortname = "DD" };
Console.WriteLine(daniel.Fullname());

Console.WriteLine("---");
Human[] members = new Human[] { adam, bretislav, cyril, daniel };
foreach (var x in members)
{
    Console.WriteLine(x.Fullname());
}
Console.WriteLine("---");
object[] xx = new object[] { adam, bretislav, cyril, daniel };
foreach (var y in xx)
{
    Console.WriteLine(y);
}