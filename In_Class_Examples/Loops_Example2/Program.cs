Console.WriteLine("What number do you want to count down from? >>");
int value = Convert.ToInt32(Console.ReadLine());

int total = 0;
for (int i = value; i > -1; i--)
{
    Console.WriteLine(i.ToString("N0"));
    total = total + i;
}

Console.WriteLine($"The total of all numbers i {total.ToString("N0")}");