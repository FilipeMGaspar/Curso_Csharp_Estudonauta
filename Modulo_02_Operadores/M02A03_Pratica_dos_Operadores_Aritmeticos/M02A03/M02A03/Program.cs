// Exemplo de operadores aritméticos

int op1 = 0;
int op2 = 0;

Console.Write("Digite um valor inteiro: ");
int.TryParse(Console.ReadLine(), out op1);
Console.Write("Digite outro número inteiro: ");
int.TryParse(Console.ReadLine(), out op2);

Console.WriteLine($"Calculando +{op1} = {+ op1}"); //operador de identidade
Console.WriteLine($"Calculando -{op1} = {- op1}"); //operador de negação aritmética
Console.WriteLine($"Calculando {op1} + {op2} = {op1 + op2}"); // Operador de adição
Console.WriteLine($"Calculando {op1} - {op2} = {op1 - op2}"); // Operador de subtração
Console.WriteLine($"Calculando {op1} x {op2} = {op1 * op2}"); // operador de multiplicação
Console.WriteLine($"Calculando {op1} ÷ {op2} = {op1 / op2} ** ERRO ** "); // operadior de divisão inteira
Console.WriteLine($"Calculando o resto da divisão de {op1} por {op2} = {op1 % op2}"); // resto da divisão inteira


Console.ReadKey();