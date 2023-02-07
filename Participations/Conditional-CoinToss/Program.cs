Random random = new Random();
int randomNbr = random.Next(1, 3);

//Console.WriteLine(randomNbr);

Console.WriteLine("Guess, Heads or Tails? <<");
string usersResponse = Console.ReadLine();

// Heads = 1
// Tails = 2

string coinTossAsWords;

if (randomNbr == 1)
{
    //Console.WriteLine("It was heads");
    coinTossAsWords = "Heads";
}
else// if (randomNbr == 2)
{
    //Console.WriteLine("It was tails");
    coinTossAsWords = "Tails";
}

Console.WriteLine("It was " + coinTossAsWords + ".");


if (coinTossAsWords == usersResponse)
{
    Console.WriteLine("Congratulations, you guessed correctly.");
}
else
{
    Console.WriteLine("Sorry, better luck next time.");
}