Dictionary<string, double> students = new Dictionary<string, double>();

do
{
    Console.WriteLine("What is the student's ID? >>");
    string id = Console.ReadLine();

    Console.WriteLine($"What is {id}'s GPA? >>");
    double gpa = Convert.ToDouble(Console.ReadLine());

    if (students.ContainsKey(id) == false)
    {
        students.Add(id, gpa);

    }
    else
    {
        Console.WriteLine($"The student with {id} already exists.  We will now update the {id} with the value {gpa}");

        students[id] = gpa;
    }

    Console.WriteLine("Do you have another student to add? yes or no >>");
} while (Console.ReadLine().ToLower() == "yes");

Console.WriteLine("Which student do you want to see the GPA of? >>");
foreach (var id in students.Keys)
{
    Console.WriteLine(id);
}

string answer = Console.ReadLine();

if (students.ContainsKey(answer) == true)
{
    Console.WriteLine($"{answer}'s GPA is {students[answer].ToString("n2")}"); 
}
else
{
    Console.WriteLine("Sorry that student does not exist.");
}