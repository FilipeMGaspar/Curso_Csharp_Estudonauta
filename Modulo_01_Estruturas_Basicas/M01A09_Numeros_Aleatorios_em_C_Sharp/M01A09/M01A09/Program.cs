Random gerador = new Random();
int n = gerador.Next(5);  // de 0 até 4
int m = gerador.Next(1, 4); // gera numeros de 1 até 3
Console.WriteLine("Acabei de gerar o número: " + n);
Console.ReadKey();