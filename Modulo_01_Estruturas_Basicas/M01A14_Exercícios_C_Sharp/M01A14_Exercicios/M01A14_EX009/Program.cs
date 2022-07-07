string nomeProd, nomeProd2;
float preco, precoProd2;
Console.WriteLine("Produto 1");
Console.Write("\tNome ..: ");
nomeProd = Console.ReadLine();
Console.Write("\tPreço ..: ");
float.TryParse(Console.ReadLine(), out preco);

Console.WriteLine("Produto 2");
Console.Write("\tNome ..: ");
nomeProd2 = Console.ReadLine();
Console.Write("\tPreço ..: ");
float.TryParse(Console.ReadLine(), out precoProd2);

Console.WriteLine($"{nomeProd2} {precoProd2, 10:C2}");

Console.ReadKey();