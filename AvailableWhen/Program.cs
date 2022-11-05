using System.Globalization;

// Welcome message
Console.WriteLine("Welcome When");
Console.WriteLine("------------");
Console.WriteLine();

// Declare variables
string actualDate = DateTime.Now.ToString("D");
string desiredDate = DateTime.UtcNow.ToString("D");

string maybeDate = "6/12/2022";
string maybeDateFormat = "d/M/yyyy";
string maybeDateReformat = "MMMM dd, yyyy hh:mm zzz";
CultureInfo maybeDateRule = CultureInfo.InvariantCulture;

DateTime maybeDateParse = DateTime.Parse(maybeDate);
string maybeDateInLocalMachine = maybeDateParse.ToString(maybeDateReformat);

DateTime maybeDateParseExact = DateTime.ParseExact(maybeDate, maybeDateFormat, maybeDateRule);
string maybeDateInAnyMachine = maybeDateParseExact.ToString(maybeDateReformat);

// Show values
Console.WriteLine($"Actual Date                 : {actualDate}");
Console.WriteLine($"Desired Date                : {desiredDate}");
Console.WriteLine();
Console.WriteLine($"Maybe Date                  : {maybeDate}");
Console.WriteLine($"Maybe Date Format           : {maybeDateFormat}");
Console.WriteLine($"Maybe Date In Local Machine : {maybeDateInLocalMachine}");
Console.WriteLine($"Maybe Date In Any Machine   : {maybeDateInAnyMachine}");
Console.ReadLine();