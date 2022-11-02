using Cst05objects;

Student adam = new Student("Adam","Kos",2, 2.3);
/*
adam.firstname = "Adam";
Console.WriteLine(adam.firstname);
Console.WriteLine(adam.lastname);
adam.firstname = "Adolf";
Console.WriteLine(adam.firstname);
*/
Console.WriteLine(adam.GetFirstname());
Console.WriteLine(adam.GetGrade());
adam.Advance();
adam.Advance();
adam.Advance();
adam.Advance();
Console.WriteLine(adam.GetGrade());
adam.SetGrade(1);
Console.WriteLine(adam.GetGrade());
Student fred = new Student();
Console.WriteLine(fred.GetGrade());
Console.WriteLine(fred);