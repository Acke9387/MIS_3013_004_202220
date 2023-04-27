using Classes_Pharmaceutical_Drugs;

string[] lines = File.ReadAllLines("Pharmaceutical Drugs.csv");

List<Drug> drugList = new List<Drug>();

for (int i = 1; i < lines.Length; i++)
{
    //Name,Company,Brand,Code,StreetName
    string[] pieces = lines[i].Split(',');
    Drug d = new Drug();
    d.Name = pieces[0];
    d.Company = pieces[1];
    d.Brand = pieces[2];
    d.Code = Convert.ToInt32(pieces[3]);
    d.StreetName = pieces[4];

    drugList.Add(d);
}
int x = 1;
foreach (Drug drugName in drugList)
{
    if (x % 5 == 0)
    {
        Console.WriteLine();
    }
        Console.Write(drugName.Name + "\t\t");
    x++;
}
Console.WriteLine("__________\n");
Console.WriteLine("Which drug do you want to see more information about? >>");
string dName = Console.ReadLine();
Console.WriteLine("\n__________\n");
foreach (Drug drugName in drugList)
{
    if (drugName.Name == dName)
    {
        Console.WriteLine(drugName);
    }
}