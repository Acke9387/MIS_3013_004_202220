
int[] ids = new int[3];
//double[] gpas = new double[3];
double[] gpas = { 2.75, 3.75, 4.0 };
ids[0] = 1;
ids[1] = 2;
ids[2] = 3;

Console.WriteLine("Please pick an ID from the list to see their GPA >>");
//for (int i = 0; i < ids.Length; i++)
//{
//    int currentId = ids[i];
//    Console.WriteLine(currentId); 
//}

foreach (int currentId in ids)
{

    Console.WriteLine(currentId);
}

int selectedID = Convert.ToInt32(Console.ReadLine());


bool didIFindAStudent = false;

for (int i = 0; i < ids.Length; i++)
{
    if (ids[i] == selectedID)
    {
        Console.WriteLine($"Student with id {selectedID.ToString("n0")} has a gpa of {gpas[i].ToString("n2")}");
        didIFindAStudent = true;
        break;
    }
}

if (didIFindAStudent == false)
{
    Console.WriteLine($"Sorry {selectedID.ToString("N0")} is not a valid student");
}