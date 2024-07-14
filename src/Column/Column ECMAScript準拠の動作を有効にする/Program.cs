using System.Text.RegularExpressions;

var text = "Ｗｉｎｄｏｗｓ１１, Windows11";
var pattern = @"\w+\d+";
foreach (Match m in Regex.Matches(text, pattern)) {
    Console.WriteLine(m.Value);
}
Console.WriteLine("---");
foreach (Match m in Regex.Matches(text, pattern, RegexOptions.ECMAScript)) {
    Console.WriteLine(m.Value);
}
