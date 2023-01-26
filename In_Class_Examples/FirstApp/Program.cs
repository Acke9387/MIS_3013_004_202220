// See https://aka.ms/new-console-template for more information
const string WELCOME_MESSAGE = "Welcome, to my application!";

Console.WriteLine(WELCOME_MESSAGE);
Console.WriteLine("What is your name? >>");
string name;
name = Console.ReadLine();

//Console.WriteLine(name + ", what is your monthly income? >>");
Console.WriteLine($"{name}, what is your monthly income? >>");
string answer = Console.ReadLine();

double monthlyIncome = Convert.ToDouble(answer);

Console.WriteLine($"{name}, what is your monthly expenses? >>");
answer = Console.ReadLine();

double monthlyExpenses = Convert.ToDouble(answer);

double total = monthlyIncome - monthlyExpenses;
Console.WriteLine($"Monthly Income ({monthlyIncome.ToString("C")}) - Monthly Expenses ({monthlyExpenses.ToString("C")}) = {total.ToString("C3")}");