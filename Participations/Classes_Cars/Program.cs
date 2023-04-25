/*
 * 
 * 
 * 
 *@Professor Ackerman
 */

using Classes_Cars;

List<Car> automobiles = new List<Car>();

string[] linesOfFile = File.ReadAllLines("Cars.csv");

for (int i = 1; i < linesOfFile.Length; i++)
{
    //  0    1     2    3    4    5
    //Make,Model,Year,Color,VIN,Price

    Car dataInput = new Car();
    string[] piecesOfLine = linesOfFile[i].Split(',');
    dataInput.Make = piecesOfLine[0];
    dataInput.Model = piecesOfLine[1];
    dataInput.Year = Convert.ToInt32(piecesOfLine[2]);
    dataInput.Color = piecesOfLine[3];
    dataInput.VIN = piecesOfLine[4];
    dataInput.Price = Convert.ToDouble(piecesOfLine[5]);

    automobiles.Add(dataInput);
}

foreach (Car c in automobiles)
{
    if (c.Year > 1999)
    {
        Console.WriteLine(c);
    }
}