using System.Text.RegularExpressions;

if (args.Length == 0) {
    Console.WriteLine("パラメータが指定されていません");
    return;
}
var file = args[0];
var lines = File.ReadAllLines(file);
var newlines = lines.Select(s => Regex.Replace(s, @"\bversion=""v4\.0""", @"version=""v5.0"""));
File.WriteAllLines(file, newlines);

// これ以降は確認用
var text = File.ReadAllText(file);
Console.WriteLine(text);