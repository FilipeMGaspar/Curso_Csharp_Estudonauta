// Entrada de dados
int n1 = 0;
int n2 = 0;

Console.Write("Valor 1: ");
int.TryParse(Console.ReadLine(), out n1);
Console.Write("Valor 2: ");
int.TryParse(Console.ReadLine(), out n2);

//Saida de dados
Console.WriteLine();
Console.WriteLine($"{n1} == {n2} ? {n1 == n2}");
Console.WriteLine($"{n1} != {n2} ? {n1 != n2}");
Console.WriteLine($"{n1} > {n2} ? {n1 > n2}");
Console.WriteLine($"{n1} < {n2} ? {n1 < n2}");
Console.WriteLine($"{n1} >= {n2} ? {n1 >= n2}");
Console.WriteLine($"{n1} <= {n2} ? {n1 <= n2}");
Console.WriteLine($"{n1} é inteiro ? {n1 is int}");

Console.ReadKey();