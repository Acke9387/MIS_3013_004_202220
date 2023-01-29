/*  Variables - Example 3
 * 
 * Change the foreground color of the Console as well 
 * as the background color and output a message.  
 * Change both to something different and output a different message.
 *  
 * */


Console.WriteLine("Hello : Variables - Example 3");

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor= ConsoleColor.Yellow;

Console.WriteLine($"Changed the colors!");

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.DarkGreen;

Console.WriteLine("Changed them again!");