using Cst15LINQ;

List<Student> students = new List<Student>
{
    new Student { FirstName = "Arnold", Classroom = "A", AverageGrade = 1.1},
    new Student { FirstName = "Bořivoj", Classroom = "B", AverageGrade = 3.5},
    new Student { FirstName = "Ctirad", Classroom = "A", AverageGrade = 1.5},
    new Student { FirstName = "Dalimil", Classroom = "A", AverageGrade = 2.5},
    new Student { FirstName = "Evžen", Classroom = "B", AverageGrade = 3.0},
    new Student { FirstName = "Fiona", Classroom = "A", AverageGrade = 1.6},
    new Student { FirstName = "Gertrude", Classroom = "B", AverageGrade = 3.8},
    new Student { FirstName = "Hilde", Classroom = "A", AverageGrade = 4.8},
    new Student { FirstName = "Igor", Classroom = "B", AverageGrade = 2.2},
    new Student { FirstName = "Johann", Classroom = "B", AverageGrade = 3.2},
    new Student { FirstName = "Knut", Classroom = "A", AverageGrade = 2.1},
    new Student { FirstName = "Libor", Classroom = "B", AverageGrade = 3.1},
    new Student { FirstName = "Magnus", Classroom = "A", AverageGrade = 1.1},
    new Student { FirstName = "Niobe", Classroom = "B", AverageGrade = 2.5},
    new Student { FirstName = "Otmar", Classroom = "A", AverageGrade = 1.1},
    new Student { FirstName = "Petra", Classroom = "B", AverageGrade = 1.6},
    new Student { FirstName = "Quido", Classroom = "A", AverageGrade = 2.5},
    new Student { FirstName = "Roland", Classroom = "A", AverageGrade = 1.8},
    new Student { FirstName = "Simon", Classroom = "B", AverageGrade = 2.1},
    new Student { FirstName = "Tadeáš", Classroom = "A", AverageGrade = 4.98},
    new Student { FirstName = "Uwe", Classroom = "B", AverageGrade = 1.1},
    new Student { FirstName = "Vanda", Classroom = "B", AverageGrade = 2.3},
    new Student { FirstName = "Wolfgang", Classroom = "A", AverageGrade = 1.1},
    new Student { FirstName = "Xénie", Classroom = "A", AverageGrade = 1.6},
    new Student { FirstName = "Yvette", Classroom = "A", AverageGrade = 1.7},
    new Student { FirstName = "Zoltán", Classroom = "B", AverageGrade = 4.1},
};

/*
foreach (Student student in students)
{
    Console.WriteLine(student);
}
*/
/*
//foreach (Student student in students.OrderBy(x => x.AverageGrade))
foreach (Student student in students.OrderBy((x) => { return x.AverageGrade; }))
{
    Console.WriteLine(student);
}
*/
/*
foreach (Student student in students.OrderByDescending((x) => { return x.AverageGrade; }))
{
    Console.WriteLine(student);
}
*/
//Console.WriteLine(students.Average(x => x.AverageGrade));
/*
foreach (Student student in students.Take(3))
{
    Console.WriteLine(student);
}
*/
/*
foreach (Student student in students.OrderBy((x) => { return x.AverageGrade; }).Take(3))
{
    Console.WriteLine(student);
}
*/
/*
foreach (Student student in students.Where(x => x.Classroom == "B"))
{
    Console.WriteLine(student);
}
*/
/*
foreach (Student student in students.Where(x => x.Classroom == "B" && x.AverageGrade < 2))
{
    Console.WriteLine(student);
}
*/
/*
foreach (Student student in students.Where(x => x.Classroom == "B").Where(x => x.AverageGrade < 2))
{
    Console.WriteLine(student);
}
*/
/*
foreach (string name in students.Select(x => x.FirstName))
{
    Console.WriteLine(name);
}
*/
/*
foreach (var x in students.GroupBy(x => x.Classroom))
{
    Console.WriteLine(x.Key + ":" + x.Average(a => a.AverageGrade));
}
*/
foreach (var st in students
    .OrderBy(x => x.AverageGrade)
    .GroupBy(x => x.Classroom)
    .Select(x => new StudentSummary {
        Classroom = x.Key,
        Count = x.Count(),
        Average = x.Average(q => q.AverageGrade) }
    )
    .OrderByDescending(s => s.Average)
    )
{
    Console.WriteLine(st);
}