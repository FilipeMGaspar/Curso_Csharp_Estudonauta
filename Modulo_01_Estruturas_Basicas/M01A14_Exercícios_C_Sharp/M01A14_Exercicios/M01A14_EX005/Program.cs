int anoNasc;
int anoAtual = DateTime.Now.Year;
Console.Write("Em que ano você nasceu? ");
int.TryParse(Console.ReadLine(), out anoNasc);
Console.WriteLine("---------------------------------------");
Console.WriteLine($"Estamos no ano de {anoAtual}");
Console.WriteLine($"Quem nasceu em {anoNasc}, tem {anoAtual - anoNasc}");
Console.ReadKey();