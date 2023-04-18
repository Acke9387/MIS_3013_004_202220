using Classes_Toy;

List<Toy> toybox = new List<Toy>();

Toy toy = new Toy();
toy.Manufacturer = "Hasbro";
toy.Name = "Buzz";
toy.Price = 50.25;
toy.SetNotes("Disney");

//Console.WriteLine(toy);

toybox.Add(toy);

Toy toy2 = new Toy("Lots of fun!");
toy2.Manufacturer = "Hasbro";
toy2.Name = "Slinky Dog";
toy2.Price = 25.99;

toybox.Add(toy2);

foreach (Toy t in toybox)
{
    Console.WriteLine(t);
}