using System.Text;
using System.Text.RegularExpressions;

TagLower(args[0]);

// これ以降は確認用
var text = File.ReadAllText(args[0]);
Console.WriteLine(text);


static void TagLower(string file) {
    var lines = File.ReadLines(file);
    var sb = new StringBuilder();
    foreach (var line in lines) {
        var s = Regex.Replace(line,
            @"<(/?)([A-Z][A-Z0-9]*)(.*?)>",
            m => {
                return string.Format("<{0}{1}{2}>", m.Groups[1].Value, m.Groups[2].Value.ToLower(), m.Groups[3].Value);
            }
        );
        sb.AppendLine(s);
    }
    File.WriteAllText(file, sb.ToString());
}

