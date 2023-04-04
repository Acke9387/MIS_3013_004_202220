Console.WriteLine("Please enter the name of an animal >>");
string animal = Console.ReadLine();
string output = Speak(animal);
Console.WriteLine(output);

output = Speak("Giraffe");
OutputMessage(output);

void OutputMessage(string msg)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine(msg);
    Console.BackgroundColor = ConsoleColor.Black;
}

string Speak(string ani)
{
    string sound;

    if (ani == "dog")
    {
        sound = "ruff";
    }
    else if (ani == "monkey") {
        sound = "ooooOOOooo";
    }
    else if(ani == "goat")
    {
        sound = "EEEEK";
    }
    else
    {
        sound = "GRRR";
    }

    return $"{ani} makes the sound {sound}";
}