/*  Variables - Example 2
 * 
 * Ask the user for a lower bound number and an upper bound number. 
 * Generate a random number between the lower and upper bound number 
 * that they gave you, using the Random class.  Once you have generated 
 * the number, inform the user of the random number you generated between their bounds.
 *  
 * */

Console.WriteLine("Please give me a number for the lower bound >>");
string answer = Console.ReadLine();
int lowerBound = Convert.ToInt32(answer);

Console.WriteLine("Please give me a number for the upper bound >>");
answer = Console.ReadLine();
int upperBound = Convert.ToInt32(answer);

Random rand = new Random();
int randomNumber = rand.Next(lowerBound, upperBound + 1);

Console.WriteLine($"The random number between {lowerBound.ToString("N0")} & {upperBound.ToString("N0")} is {randomNumber.ToString("N0")}");
