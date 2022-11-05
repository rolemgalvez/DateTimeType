using System.Globalization;

// Welcome message
Console.WriteLine("Due Date");
Console.WriteLine("--------");
Console.WriteLine();

// Declare variables
string plannedDeadline = DateTime.UtcNow.ToString("F");
string actualDeadline = DateTime.Now.ToString("F");

string revisedDeadline = "2022-08-12 13:59 +08:00";
string formatOfRevisedDeadline = "yyyy-MM-dd H:mm zzz";
string targetFormatOfRevisedDeadline = "MMMM dd, yyyy hh:mm tt zzz";
CultureInfo ruleOfRevisedDeadline = CultureInfo.InvariantCulture;

DateTime parseOfRevisedDeadline = DateTime.Parse(revisedDeadline);
string inLocalMachineRevisedDeadLine = parseOfRevisedDeadline.ToString(targetFormatOfRevisedDeadline);

DateTime parseExactOfRevisedDeadline = DateTime.ParseExact(revisedDeadline, formatOfRevisedDeadline, ruleOfRevisedDeadline);
string anyMachineRevisedDeadline = parseExactOfRevisedDeadline.ToString(targetFormatOfRevisedDeadline);

// Show values
Console.WriteLine($"Planned Deadline                          : {plannedDeadline}");
Console.WriteLine($"Actual Deadline                           : {actualDeadline}");
Console.WriteLine();
Console.WriteLine($"Revised Deadline                          : {revisedDeadline}");
Console.WriteLine($"Revised Deadline's Format                 : {formatOfRevisedDeadline}");
Console.WriteLine($"Revised Deadline's Target Format          : {targetFormatOfRevisedDeadline}");
Console.WriteLine($"Revised Deadline's Rule In Any Machine    : {ruleOfRevisedDeadline}");
Console.WriteLine($"Revised Deadline's Value In Local Machine : {inLocalMachineRevisedDeadLine}");
Console.WriteLine($"Revised Deadline's Value In Any Machine   : {anyMachineRevisedDeadline}");
Console.ReadLine();




