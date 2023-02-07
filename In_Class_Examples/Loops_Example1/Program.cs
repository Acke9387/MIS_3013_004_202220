int countBy;
Console.WriteLine("What number do you want to count by? >>");
string answer = Console.ReadLine();
//countBy = Convert.ToInt32(answer);
bool isAnswerReallyANumber = int.TryParse(answer, out countBy);
if (isAnswerReallyANumber == false)
{
    Console.WriteLine("Invalid input. Goodbye.");
    Environment.Exit(1);
    //return;
}

Console.WriteLine("What number do you want to count to? >>");
int countTo = Convert.ToInt32(Console.ReadLine());

int total = countBy;
Console.WriteLine("While Loop");
while (total <= countTo)
{
    Console.WriteLine(total.ToString("N"));
    total = total + countBy;
}

Console.WriteLine("\nForLoop");
for (int i = countBy; i <= countTo; i +=  countBy)
{
    Console.WriteLine(i.ToString("N0"));
}