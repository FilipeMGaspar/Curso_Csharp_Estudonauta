// Conversão implicita int->float
/*
int a = 7;
float b = a;

Console.WriteLine("A = " + a + " do tipo " + a.GetType());
Console.WriteLine("B = " + b + " do tipo " + b.GetType());
*/

// Conversão Explicita por cast coerção float->int
/*
float a = 7.75f;
int b = (int)a; 

Console.WriteLine("A = " + a + " do tipo " + a.GetType());
Console.WriteLine("B = " + b + " do tipo " + b.GetType());*/

// conversão por classes auxiliares
float a = 7.99999999f;
int b = Convert.ToInt16(a); // to fhort

Console.WriteLine("A = " + a + " do tipo " + a.GetType());
Console.WriteLine("B = " + b + " do tipo " + b.GetType());


Console.ReadKey();