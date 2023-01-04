using Csc06PostalBag;

var l = new Letter("Adam","Beáta");
Console.WriteLine(l.Price);
l.Registered = true;
Console.WriteLine(l.Price);