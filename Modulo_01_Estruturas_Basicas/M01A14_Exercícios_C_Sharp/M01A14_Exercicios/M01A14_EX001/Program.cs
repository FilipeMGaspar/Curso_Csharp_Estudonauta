Console.SetCursorPosition(10, 5);
Thread.Sleep(1000);
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
Console.Write(" Meu ");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Green;
Thread.Sleep(1000);
Console.Write(" Brasil ");
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Yellow;
Thread.Sleep(1000);
Console.WriteLine(" Brasileiro ");
Console.ResetColor();

Console.ReadKey();