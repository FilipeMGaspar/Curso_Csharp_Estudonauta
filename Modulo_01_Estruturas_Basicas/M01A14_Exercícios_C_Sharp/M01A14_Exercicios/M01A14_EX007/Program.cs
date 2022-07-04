int inicio;
int fim;

//gerador = new Random;

Console.WriteLine("SORTEADOR DE NÚMERO");
Console.WriteLine("-------------------");
Console.Write("Início: ");
int.TryParse(Console.ReadLine(), out inicio);
Console.Write("Fim: ");
int.TryParse(Console.ReadLine(), out fim);
Console.WriteLine("-------------------");
Thread.Sleep(1000);
Console.Write("Vou sertear um número ");
Thread.Sleep(350);
Console.Write(".");
Thread.Sleep(350);
Console.Write(".");
Thread.Sleep(350);
Console.Write(".");
Thread.Sleep(350);
Console.Write(".");
Thread.Sleep(350);
Console.Write(".\n");
Thread.Sleep(600);
Console.WriteLine($"Entre {inicio} e {fim} sorteei o número ");
Console.ReadKey();