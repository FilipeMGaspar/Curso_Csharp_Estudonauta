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

Console.SetCursorPosition(0, 10);
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($" Produto {null, 20} Preço ");

Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($"{nomeProd} {precoProd,30:C2}");
Console.WriteLine($"{nomeProd2} {precoProd2, 30:C2}");

Console.ResetColor();

Console.ReadKey();