string nomeProd;
float preco;
Console.WriteLine("Produto");
Console.Write("\tNome ..: ");
nomeProd = Console.ReadLine();
Console.Write("\tPreço ..: ");
float.TryParse(Console.ReadLine(), out preco);

Console.WriteLine($"{nomeProd} {preco, 10:C2}");

Console.ReadKey();