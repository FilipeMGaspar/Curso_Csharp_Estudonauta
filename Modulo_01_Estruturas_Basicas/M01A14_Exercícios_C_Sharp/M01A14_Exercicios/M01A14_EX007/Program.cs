int inicio;
int fim;

Console.WriteLine("SORTEADOR DE NÚMERO");
Console.WriteLine("-------------------");
Console.Write("Início: ");
int.TryParse(Console.ReadLine(), out inicio);
Console.Write("Fim: ");
int.TryParse(Console.ReadLine(), out fim);
Console.WriteLine("-------------------");

Console.ReadKey();