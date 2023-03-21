List<string> favoriteThings = new List<string>();

do
{

    Console.WriteLine("Sir/Madaam, please tell me one of your favorite things >>");
    string thing = Console.ReadLine();
    favoriteThings.Add(thing);
    //favoriteThings.Add(Console.ReadLine());
    Console.WriteLine("Do you have another favorite thing to tell me about? yes or no >>");

} while (Console.ReadLine().ToLower()[0] == 'y');

Console.WriteLine("All your favorite things are:");


foreach (var thing in favoriteThings)
{
    Console.WriteLine(thing);
}

Random rand = new Random();
int randomThingIndex = rand.Next(0, favoriteThings.Count);

Console.WriteLine($"A random thing from your list is {favoriteThings[randomThingIndex]}");