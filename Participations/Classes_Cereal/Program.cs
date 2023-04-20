

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
    double calories = Convert.ToDouble(partsOfLine[2]);
    
    c.Name = name;
    c.Calories = calories;
    c.Manufacturer = partsOfLine[1];
    c.Cups = Convert.ToDouble(partsOfLine[3]);

    cereals.Add(c);
}


// Output all the cereal information that has a serving size of 1 cup or more
Console.WriteLine("Cereals with 1 cup or more per serving");
foreach (Cereal cereal in cereals)
{
    if (cereal.Cups >= 1)
    {
        Console.WriteLine(cereal);
    }
}

// Output all the cereal information that has 100 calories or less

Console.WriteLine("\n\nCereals with less than 100 calories");
foreach (Cereal cereal in cereals)
{
    if (cereal.Calories <=  100)
    {
        Console.WriteLine(cereal);
    }
}