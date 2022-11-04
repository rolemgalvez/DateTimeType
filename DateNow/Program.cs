

// Welcome message
Console.WriteLine("Date Now");
Console.WriteLine("--------");
Console.WriteLine();

// Declare variables
DateTime dateNow = DateTime.Now;
string day = dateNow.ToString("dd");
string month = dateNow.ToString("MMMM");
string year = dateNow.ToString("yyyy");

// Show values
Console.WriteLine($"I just want to share, it's day {day} of {month} {year}.");
Console.WriteLine();
Console.WriteLine("That's all. Bye!");
Console.ReadLine();