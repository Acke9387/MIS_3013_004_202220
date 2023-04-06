string[] names = new string[5];
int[] ids = { 1, 2, 3, 4, 5 };
List<List<double>> grades = new List<List<double>>();
names[0] = "Joe";
names[1] = "Sam";
names[2] = "Talia";
names[3] = "Micah";
names[4] = "Tim";

//grades.Add(new List<double>());
//grades[0].Add(67);
//grades[0].Add(78);
//grades[0].Add(97);

//grades.Add(new List<double>());
//grades[1].Add(67);
//grades[1].Add(78);
//grades[1].Add(97);
//grades[1].Add(97);
for (int i = 0; i < 5; i++)
{
    grades.Add(CreateRandomSizedListWithRandomValues());
}


for (int i = 0; i < names.Length; i++)
{
    StudentInformation(names[i], ids[i], grades[i]); 
}


void StudentInformation(string name, int id, List<double> grds)
{
    string output = "";

    double sum = 0;

    foreach (var grade in grds)
    {
        sum += grade;
    }

    double average = sum / grds.Count;
    //average = grds.Average();

    Console.WriteLine($"{name}-{id} has {grds.Count.ToString("N0")} grades with an average of {average.ToString("N2")}");

}


static List<double> CreateRandomSizedListWithRandomValues()
{
    List<double> randoGrades = new List<double>();
    Random rand = new Random();
    int numberOfGrades = rand.Next(3, 8);

    for (int i = 0; i < numberOfGrades; i++)
    {
        double grade = rand.NextDouble() * 100;
        randoGrades.Add(grade);
    }

    return randoGrades;
}