using Cst07Inheritance;


Human antonio = new Human { Firstname = "António", Lastname = "Avatar" };
Human boris = new Human("Boris","Borec");
Student cecil = new Student("Cecil","Cudný","P2B");
Console.WriteLine(antonio);
Console.WriteLine(cecil);
Human daniel = new Student("Daniel","Drsný","D1A");
Console.WriteLine(daniel);
//Student emil = new Human("Emil","Evil");