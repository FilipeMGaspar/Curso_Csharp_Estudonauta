int dia = DateTime.Now.Day;
int mes = DateTime.Now.Month;
int ano = DateTime.Now.Year;
Console.SetCursorPosition(10 , 5); // coluna, linha
Console.WriteLine(dia + "/" + mes + "/" + ano);

int hora = DateTime.Now.Hour;
int minuto = DateTime.Now.Minute;
int segundo = DateTime.Now.Second;
Console.SetCursorPosition (10 , 6); // coluna, linha
Console.WriteLine(hora + ":"+ minuto + ":" + segundo);
Console.ReadKey();