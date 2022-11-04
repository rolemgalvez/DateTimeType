using System.Globalization;

// Welcome message
Console.WriteLine("Date Now");
Console.WriteLine("--------");
Console.WriteLine();

// Declare variables
string localDateNow = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt zzz");
string utcDateNow = DateTime.UtcNow.ToString("MMMM dd, yyyy hh:mm tt zzz"); 

string dateToConvert = "6/12/2022";
DateTime customLocalMachineDate = DateTime.Parse(dateToConvert);

string dateLabel = "d/M/yyyy";
CultureInfo dateRule = CultureInfo.InvariantCulture;
DateTime customIndependentMachineDate = DateTime.ParseExact(dateToConvert, dateLabel, dateRule);

// Show values
Console.WriteLine($"Local date now is {localDateNow}.");
Console.WriteLine($"UTC date now is {utcDateNow}");
Console.WriteLine();
Console.WriteLine($"String to convert to date is \"{dateToConvert}\".");
Console.WriteLine($"Its date equivalent in the local machine is {customLocalMachineDate}.");
Console.WriteLine($"If the format of the given string is \"{dateLabel}\",");
Console.WriteLine($"Then its date equivalent independent of any machine is {customIndependentMachineDate}");
Console.WriteLine();
Console.WriteLine("That's all. Bye!");
Console.ReadLine();