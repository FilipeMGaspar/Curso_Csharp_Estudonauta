int n1 = 0;
int n2 = 0;

Console.Write("Vaolor 1: ");
int.TryParse(Console.ReadLine(), out n1);
Console.Write("Valor 2: ");
int.TryParse(Console.ReadLine(), out n2);

Console.WriteLine($"{n1} == {n2} ? {n1 == n2}");
Console.WriteLine($"{n1} != {n2} ? {n1 != n2}");
Console.WriteLine($"{n1} > {n2} ? {n1 > n2}");
Console.WriteLine($"{n1} < {n2} ? {n1 < n2}");
Console.WriteLine($"{n1} >= {n2} ? {n1 >= n2}");
Console.WriteLine($"{n1} <= {n2} ? {n1 <= n2}");

Console.ReadKey();