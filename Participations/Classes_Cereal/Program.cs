
using Classes_Cereal;

string entireFile = File.ReadAllText("Cereal_Data.txt");

//Console.WriteLine(entireFile);

string[] eachLineOfFile = File.ReadAllLines("Cereal_Data.txt");

List<Cereal> cereals = new List<Cereal>();

for (int i = 1; i < eachLineOfFile.Length; i++)
{
    Cereal c = new Cereal();

    //Console.WriteLine(eachLineOfFile[i]);
    //                      0        1           2     3
    //eachLineOfFile[i] = "name|manufacturer|calories|cups"

    string[] partsOfLine = eachLineOfFile[i].Split('|');
    //partsOfLine[0] = "name"
    //partsOfLine[1] = "manufacturer"
    //partsOfLine[2] = "calories"
    //partsOfLine[3] = "cups"

    string name = partsOfLine[0];
    c.Name = name;
    double calories = Convert.ToDouble(partsOfLine[2]);
    Console.WriteLine($"{name} has {calories.ToString("N")}");

    cereals.Add(c);
}