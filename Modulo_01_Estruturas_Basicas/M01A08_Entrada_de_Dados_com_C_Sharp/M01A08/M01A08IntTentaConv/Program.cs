/* Tenta/testa conversão */
int num = 0;
int d;

Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), out num);
d = num * 2;
Console.WriteLine("O dobro de " + num + " é " + d);
Console.ReadKey();