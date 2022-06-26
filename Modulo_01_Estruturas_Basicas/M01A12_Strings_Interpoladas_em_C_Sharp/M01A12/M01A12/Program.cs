string nome;
Console.Write("Qual é o seu nome? ");
nome = Console.ReadLine();
//Console.WriteLine("Olá " + nome + "! Tudo bem?" );
Console.WriteLine($"Olá {nome}! Tudo bem?");

int dia = DateTime.Now.Day;
int mes = DateTime.Now.Month;
int ano = DateTime.Now.Year;

Console.ReadKey();