float nota1 = 0f;
float nota2 = 0f;

Console.Write("Insira a nota do primeiro teste: ");
float.TryParse(Console.ReadLine(), out nota1);
Console.Write("Insira a nota do segundo teste: ");
float.TryParse(Console.ReadLine(), out nota2);

float media = (nota1 + nota2) / 2;

Console.WriteLine($"As notas registadas foram {nota1:F1} pontos e {nota2:F1} pontos");
Console.WriteLine($"A média do aluno foi de {media:F1} pontos");
Console.ReadKey();