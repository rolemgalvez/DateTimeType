using System.Globalization;

// Welcome message
Console.WriteLine("What Time Now");
Console.WriteLine("-------------");
Console.WriteLine();

// Declare variables
string timeNow = DateTime.Now.ToString("hh:mm tt zzz");
string utcTimeNow = DateTime.UtcNow.ToString("hh:mm tt zzz");

string customTime = "12:30 PM +8:00";
string timeFormat = "hh:mm tt zzz";
CultureInfo timeRule = CultureInfo.InvariantCulture;
string customTimeLocal = DateTime.Parse(customTime).ToString(timeFormat);
string customTimeIndependent = DateTime.ParseExact(customTime, timeFormat, timeRule).ToString(timeFormat);

// Show values
Console.WriteLine($"Local Time Now               : {timeNow}");
Console.WriteLine($"UTC Time Now                 : {utcTimeNow}");
Console.WriteLine();
Console.WriteLine($"Custom Time                  : {customTime}");
Console.WriteLine($"Time Format                  : {timeFormat}");
Console.WriteLine($"Custom Time in Local Machine : {customTimeLocal}");
Console.WriteLine($"Custom Time in Any Machine   : {customTimeIndependent}");
Console.ReadLine();