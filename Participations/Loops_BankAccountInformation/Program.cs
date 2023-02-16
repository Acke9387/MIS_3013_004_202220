
Console.WriteLine("How many bank accounts do you have? >>");
string answer = Console.ReadLine();

int numberOfAccounts;

while (int.TryParse(answer, out numberOfAccounts) == false)
{
    Console.WriteLine("That value is invalid, please tell me a valid number of bank accounts >>");
    answer = Console.ReadLine();
}


double total = 0;
for (int i = 1; i <= numberOfAccounts; i++)
{
    Console.WriteLine($"What is your bank account balance for account #{i.ToString("N0")}");
    double balance = Convert.ToDouble(Console.ReadLine());
    total = total + balance;
}


Console.WriteLine($"Your total balance of all accounts is {total.ToString("C")}");

double averageBalance = total / numberOfAccounts;

if (averageBalance > 5000)
{
    Console.ForegroundColor =  ConsoleColor.Green; //(ConsoleColor)10
}

Console.WriteLine($"Your average balance of your accounts is {averageBalance.ToString("C")}");
Console.ForegroundColor = ConsoleColor.White;