/* Lendo numeros */
/* Mandei converter dá erro se vir uma string*/
int num, d;

Console.Write("Insira um número: ");
num = Convert.ToInt32(Console.ReadLine());
d = num * 2;
Console.Write("O dobro de " + num + " é igual a " + d);
Console.ReadKey();