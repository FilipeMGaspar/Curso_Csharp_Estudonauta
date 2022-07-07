string nomeProd, nomeProd2;
float precoProd, precoProd2;

//Primeiro produto
Console.WriteLine("Produto 1");
Console.Write("\tNome ..: ");
nomeProd = Console.ReadLine();
Console.Write("\tPreço ..: ");
float.TryParse(Console.ReadLine(), out precoProd);

Console.WriteLine();
//Segundo produto
Console.WriteLine("Produto 2");
Console.Write("\tNome ..: ");
nomeProd2 = Console.ReadLine();
Console.Write("\tPreço ..: ");
float.TryParse(Console.ReadLine(), out precoProd2);


Console.WriteLine($"{nomeProd} {precoProd,10:C2}");
Console.WriteLine($"{nomeProd2} {precoProd2, 10:C2}");

Console.ReadKey();