int dia = DateTime.Now.Day;
int mes = DateTime.Now.Month;
int ano = DateTime.Now.Year;

Console.Write("Hoje dia ");
Thread.Sleep(1000); // tempo em milisegundos
Console.Write(dia);
Thread.Sleep(1000);
Console.Write(" do mês ");
Thread.Sleep(1000);
Console.Write(mes);
Thread.Sleep(1000);
Console.Write(" no ano de ");
Thread.Sleep(1000);
Console.Write(ano);

Thread.Sleep(2000);
//Console.ReadKey();