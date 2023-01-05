// fronta požadavků
// tisková fronta
// FIFO - First In First Out

Queue<int> fronta = new Queue<int> ();
fronta.Enqueue(100);
fronta.Enqueue(200);
fronta.Enqueue(300);
foreach(var x in fronta)
{
    Console.WriteLine(x);
}
Console.WriteLine("-" + fronta.Dequeue());
foreach (var x in fronta)
{
    Console.WriteLine(x);
}
Console.WriteLine(fronta.Peek());
Console.WriteLine(fronta.Count);
Console.WriteLine("-" + fronta.Dequeue());
Console.WriteLine("-" + fronta.Dequeue());
// Console.WriteLine("-" + fronta.Dequeue()); // výjimka

// volání podprogramů
// rekurentní programy
// LIFO - Last In First Out

Stack<int> zas = new Stack<int>();
zas.Push(100);
zas.Push(200);
zas.Push(300);
foreach (var x in zas)
{
    Console.WriteLine(x);
}
Console.WriteLine("-" + zas.Pop());
foreach (var x in zas)
{
    Console.WriteLine(x);
}
Console.WriteLine(zas.Peek());
Console.WriteLine(zas.Count);
// Stack overflow