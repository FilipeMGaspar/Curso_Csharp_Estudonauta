int num = 13;
string nome = "Filipe";
float sal = 550.7556f;
int idade = 22;

Console.WriteLine($"O {nome, -10} tem {idade, -5:D3} anos e ganha {sal, 10:C3} por mês");
Console.WriteLine($"O número foi {num:X}");

//Console.WriteLine($"Muito prazer {nome, -3}");

Console.ReadKey();

/*  Formatação numérica
 *  
    :C  Moeda (currency)
    
    :D  Decimal (inteiro)
    
    :N  Número (real)

    :E  Científico

    :X  Hexadecimal
 */