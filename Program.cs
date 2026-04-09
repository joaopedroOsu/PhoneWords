
Console.WriteLine("Telefone");
string telefone = Console.ReadLine()!;

telefone = telefone.Remove(3)!;
telefone = telefone.Insert(3, "-PIZZA");



Console.WriteLine(telefone);
