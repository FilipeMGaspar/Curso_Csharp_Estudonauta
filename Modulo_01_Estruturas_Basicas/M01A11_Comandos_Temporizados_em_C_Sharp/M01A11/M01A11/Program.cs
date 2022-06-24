int dia = DateTime.Now.Day;
int mes = DateTime.Now.Month;
int ano = DateTime.Now.Year;

Console.Write("Hoje ");
Thread.Sleep(1000); // tempo em milisegundos
Console.Write(dia);
Thread.Sleep(1000);
Console.Write(" do mês ");
Thread.Sleep(1000);
Console.WriteLine(mes);
Thread.Sleep(1000);
Console.WriteLine(" do ano de ");
Thread.Sleep(1000);
Console.Write(ano);

Console.ReadKey();