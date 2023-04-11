using Classes_RectangleAndCircle;


Rectangle r = new Rectangle();
r.Width = 5;
r.Length = 10;

double area = r.CalculateArea();
double perimeter = r.CalculatePerimeter();
Console.WriteLine($"The area for the Rectangle with {r.Width} width and {r.Length} length is {area}.  The perimeter is {perimeter}");

Rectangle r1 = new Rectangle();
r1.Width = 25;
r1.Length = 10;

area = r1.CalculateArea();
perimeter = r1.CalculatePerimeter();
Console.WriteLine($"The area for the Rectangle with {r1.Width} width and {r1.Length} length is {area}.  The perimeter is {perimeter}");

Console.WriteLine("What is the width of the Rectangle? >>");
double width = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the length of the Rectangle? >>");
double length = Convert.ToDouble(Console.ReadLine()); 

Rectangle r2 = new Rectangle(width, length);

List<Rectangle> allMyRectangles = new List<Rectangle>();
allMyRectangles.Add(r);
allMyRectangles.Add(r1);
allMyRectangles.Add(r2);

foreach (Rectangle rect in allMyRectangles)
{
    Console.WriteLine(rect);
}
