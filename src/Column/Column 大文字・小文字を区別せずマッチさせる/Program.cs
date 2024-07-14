using System.Text.RegularExpressions;

var text = "jpn, JPN, Jpn";
var matches = Regex.Matches(text, @"\bjpn\b", RegexOptions.IgnoreCase);
foreach (Match m in matches) {
    Console.WriteLine(m.Value);
}
