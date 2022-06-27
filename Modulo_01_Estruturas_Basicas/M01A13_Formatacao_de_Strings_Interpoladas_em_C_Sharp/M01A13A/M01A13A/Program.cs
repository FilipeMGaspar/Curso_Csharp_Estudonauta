System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
ci.NumberFormat.CurrencySymbol = "€";
//System.Threading.Thread.CurrentThread.CurrentCulture = ci;

string nome = "Filipe";
float sal = 550.7556f;

Console.WriteLine($"O {nome, -10} ganha {sal, 10:c3} por mês");

//Console.WriteLine($"Muito prazer {nome, -3}");

Console.ReadKey();