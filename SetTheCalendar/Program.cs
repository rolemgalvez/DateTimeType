using System.Globalization;

// Welcome message
Console.WriteLine("Set The Calendar");
Console.WriteLine("----------------");
Console.WriteLine();

// Declare variables
string actualPickDate = DateTime.Now.ToString("g");
string partialPickDate = DateTime.UtcNow.ToString("g");

string notPickDate = "August 12, 2022 02:59 PM";
string notPickDateFormat = "MMMM dd, yyyy hh:mm tt";
string notPickDateReformat = "dd-M-yyyy H:mm";
CultureInfo notPickDateRule = CultureInfo.InvariantCulture;

DateTime notPickDateParse = DateTime.Parse(notPickDate);
string notPickDateInLocalMachine = notPickDateParse.ToString(notPickDateReformat);

DateTime notPickDateParseExact = DateTime.ParseExact(notPickDate, notPickDateFormat, notPickDateRule);
string notPickDateInAnyMachine = notPickDateParseExact.ToString(notPickDateReformat);

// Show values
Console.WriteLine($"Actual Pick Date               : {actualPickDate}");
Console.WriteLine($"Partial Pick Date              : {partialPickDate}");
Console.WriteLine();
Console.WriteLine($"Not Pick Date                  : {notPickDate}");
Console.WriteLine($"Not Pick Date Format           : {notPickDateFormat}");
Console.WriteLine($"Not Pick Date Reformat         : {notPickDateReformat}");
Console.WriteLine($"Not Pick Date In Local Machine : {notPickDateInLocalMachine}");
Console.WriteLine($"Not Pick Date In Any Machine   : {notPickDateInAnyMachine}");
Console.ReadLine();