string answer;
do
{
    Console.WriteLine("Please tell me a word >>");
    string word = Console.ReadLine();

    for (int i = 0; i < word.Length; i +=2)
    {
        Console.Write(word[i]);
    }
    Console.WriteLine();
    word = word.Replace("e", "3");

    Console.WriteLine(word);

    Console.WriteLine("Do you want to go again? yes or no >>");
    answer = Console.ReadLine().ToLower();
    answer = answer.ToLower();
} while (answer.ToLower()[0] == 'y');

