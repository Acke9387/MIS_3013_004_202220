﻿const string DEVELOPER_INFORMATION = "Professor Ackerman";
int randomNumber = 0;

Random r = new Random();
randomNumber = r.Next(1, 100 + 1);

randomNumber = 1;
if (randomNumber % 3 == 0 && randomNumber % 5 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (randomNumber % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (randomNumber % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(randomNumber.ToString("N0"));
}

Console.WriteLine(DEVELOPER_INFORMATION);