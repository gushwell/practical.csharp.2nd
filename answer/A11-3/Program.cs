using System.Text.RegularExpressions;

string[] texts = [
    "Time is money.",
    "What time is it?",
    "It will take time.",
    "We reorganized the timetable.",
];

foreach (var line in texts) {
    var matches = Regex.Matches(line, @"\btime\b", RegexOptions.IgnoreCase);
    foreach (Match m in matches) {
        Console.WriteLine("{0}: {1}", line, m.Index);
    }
}

