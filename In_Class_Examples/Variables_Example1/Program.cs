/*  Variables - Example 1
 * 
 * Welcome the user to your application and prompt the user to enter their name.  
 * Prompt the user, while using their name, for their total monthly income as well 
 * as their total monthly expenses.Output the difference between the two values.
 *  
 * */

Console.WriteLine("Welcome to my application!");
Console.WriteLine("Please enter your name >>");
string name = Console.ReadLine(); //getting input from the user

Console.WriteLine(name + ", what is your monthly income? >>" + "" + ""); //Normal string concatenation
string answer = Console.ReadLine();
double income = Convert.ToDouble(answer);

Console.WriteLine($"{name}, what is your monthly expenses? >>"); //String interpretation
answer = Console.ReadLine();
double expenses = Convert.ToDouble(answer);

double total = (income - expenses);
Console.WriteLine($"{income.ToString("C")} - {expenses.ToString("C")} = {total.ToString("C3")}");

