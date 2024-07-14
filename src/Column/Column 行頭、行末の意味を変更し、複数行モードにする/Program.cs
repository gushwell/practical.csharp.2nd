using System.Text.RegularExpressions;

var text = "Word\nExcel\nPowerPoint\nOutlook\nOneDrive\n";
var pattern = @"^[a-zA-Z]{5,7}$";
var matches = Regex.Matches(text, pattern, RegexOptions.Multiline);
foreach (Match m in matches) {
    Console.WriteLine($"{m.Index} {m.Value}");
}
