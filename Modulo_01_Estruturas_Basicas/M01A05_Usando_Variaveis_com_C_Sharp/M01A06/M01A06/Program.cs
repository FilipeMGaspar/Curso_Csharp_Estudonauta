const string ESCOLA = "Estudonauta";
const short num = 21;
short n = 10;
const float PI = 3.14159265f;

Console.WriteLine("Estudo no " + ESCOLA);
Console.WriteLine("Contante num = " + num);
Console.WriteLine("Variavel n = " + n);
n = 21;
Console.WriteLine("Variavel n = " + n);
// ESCOLA = "Curso Em video"; // Comando dá erro pois uma constante não pode ser modificado o seu valor
// Console.WriteLine("Agora estudo no " + ESCOLA);

Console.WriteLine("Valor de PI = " + PI);
Console.ReadKey();