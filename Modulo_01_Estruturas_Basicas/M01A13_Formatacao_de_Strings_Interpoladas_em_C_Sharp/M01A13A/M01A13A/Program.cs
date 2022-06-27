string nome = "Filipe";
float sal = 550.7556f;
int idade = 22;

Console.WriteLine($"O {nome, -10} tem {idade} anos e ganha {sal, 10:c3} por mês");

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