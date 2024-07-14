if (args.Length == 0)
    return;
var file = args[0];

var count = 0;
using (var sr = new StreamReader(file)) {
    while (!sr.EndOfStream) {
        var line = sr.ReadLine();
        if (line!.Contains(" class "))
            count++;
    }
}
Console.WriteLine(count);
