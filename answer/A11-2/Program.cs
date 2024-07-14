using System.Text.RegularExpressions;
if (args.Length == 0)
    return;
var file = args[0];
Pickup3DigitNumber(file);

static void Pickup3DigitNumber(string file) {
    foreach (var line in File.ReadLines(file)) {
        var matches = Regex.Matches(line, @"\b\d{3,}\b");
        foreach (Match m in matches) {
            Console.WriteLine(m.Value);
        }
    }
}