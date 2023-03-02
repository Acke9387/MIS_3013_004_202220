//string[] linesOfFile = File.ReadAllLines();

//Gets us 1 string that is ALL of the contents of the file
string contentsOfFile = File.ReadAllText("The stainless steel rat by Harry Harrison.txt");

//Gets us a string for EACH line of the file --> MANY STRINGS
string[] linesOfFile = File.ReadAllLines("The stainless steel rat by Harry Harrison.txt");

//Console.WriteLine(linesOfFile[0]);
//Console.WriteLine(linesOfFile[1]);
//Console.WriteLine(linesOfFile[2]);

bool shouldWriteToConsole = false;

for (int i = 0; i < linesOfFile.Length; i++)
{
    string line = linesOfFile[i];

    if(line.Contains("THE END") == true)
    {
        Console.WriteLine(line);
        break;
    }

    if (shouldWriteToConsole == false && line.Contains("Title") == false)
    {
        continue;
    }
    else
    {
        shouldWriteToConsole = true;
    }

    Console.WriteLine(linesOfFile[i]);
    if (i % 5 == 0 && i != 0)
    {
        Console.ReadKey();
    }
}

//Console.WriteLine(contentsOfFile);

Console.ForegroundColor = ConsoleColor.Green;
Console.ReadKey();