if (args.Length == 0)
    return;
var file = args[0];

var count = File.ReadLines(file)
                .Count(s => s.Contains(" class "));
Console.WriteLine(count);
