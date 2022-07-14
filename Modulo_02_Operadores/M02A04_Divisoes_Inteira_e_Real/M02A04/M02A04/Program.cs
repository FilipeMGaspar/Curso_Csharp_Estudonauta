int op1 = 0;
int op2 = 0;

Console.Write("Numerador: ");
int.TryParse(Console.ReadLine(), out op1);

Console.Write("Denominador: ");
int.TryParse(Console.ReadLine(), out op2);

int divInt = op1 / op2;

float divReal = (float)op1 / op2;

Console.WriteLine($"Divisão inteira {op1} ÷ {op2} = {divInt}");
Console.WriteLine($"Divisão real {op1} ÷ {op2} = {divReal}");

Console.ReadKey();