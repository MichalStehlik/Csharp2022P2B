using Cst09Abstraction;

Human alois = new Human { Firstname = "Alois", Lastname = "Oplatka" };
Student boris = new Student { Firstname = "Boris", Lastname = "Blatný", Grade = 1.0 };
Dolphin filip = new Dolphin { Name = "Filip" };
// Entity x = new Entity();

Entity[] members = new Entity[] { alois, boris, filip };
foreach (var m in members)
{
    Console.WriteLine(m);
}

IGradeable[] students = new IGradeable[] { boris, filip };
foreach (var s in students) // IEnumerable
{
    Console.WriteLine(s.Grade);
    if (s is Student)
    {
        Console.WriteLine((s as Student).Lastname);
    }
}