int inicio;
int fim;

Console.WriteLine("SORTEADOR DE NÚMERO");
Console.WriteLine("-------------------");
Console.Write("Início: ");
int.TryParse(Console.ReadLine(), out inicio);
Console.Write("Fim: ");
int.TryParse(Console.ReadLine(), out fim);
Console.WriteLine("-------------------");
Thread.Sleep(1000);
Console.WriteLine("Vou sertear um número ");
Thread.Sleep(200);
Console.Write(".");
Thread.Sleep(200);
Console.Write(".");
Thread.Sleep(200);
Console.Write(".");
Thread.Sleep(200);
Console.Write(".");

Console.ReadKey();