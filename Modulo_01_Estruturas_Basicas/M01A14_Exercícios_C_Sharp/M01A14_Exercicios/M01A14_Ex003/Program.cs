float num = 0f;
Console.Write("Digite um número real: ");
float.TryParse(Console.ReadLine(), out num);

Console.WriteLine("----------------------------");
Console.WriteLine($"Você digitou o valor {num}");
Console.WriteLine($"A parte inteira do número é {(int)num}");
Console.ReadKey();