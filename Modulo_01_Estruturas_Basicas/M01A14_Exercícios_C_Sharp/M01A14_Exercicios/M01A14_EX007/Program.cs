int inicio;
int fim;

Random gerador = new Random();

Console.WriteLine("SORTEADOR DE NÚMERO");
Console.WriteLine("-------------------");
Console.Write("Início: ");
int.TryParse(Console.ReadLine(), out inicio);
Console.Write("Fim: ");
int.TryParse(Console.ReadLine(), out fim);

int sorte = gerador.Next(inicio, (fim +1));
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
Thread.Sleep(700);
Console.WriteLine();
Console.WriteLine($"Entre {inicio} e {fim} sorteei o número {sorte}");
Console.ReadKey();