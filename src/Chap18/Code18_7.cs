using System.Text;
using System.Text.RegularExpressions;

public class Code18_7 {
    private string[] GetUpperWords(string path) {
        var list = new List<string>();
        if (String.Compare(Path.GetExtension(path), ".txt", ignoreCase: true) != 0)
            return list.ToArray();
        if (!File.Exists(path))
            return list.ToArray();
        using var reader = new StreamReader(path, Encoding.UTF8);
        while (!reader.EndOfStream) {
            var line = reader.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
                continue;
            var words = ExtractWords(line);
            list.AddRange(words);
        }
        return list.ToArray();
    }

    private IEnumerable<string> ExtractWords(string line) {  //- メソッドとして独立させる
        var matches = Regex.Matches(line, @"\b\w{2,}\b");
        foreach (Match match in matches) {
            var word = match.Value;
            if (word.All(c => char.IsUpper(c)))
                yield return word;
        }
    }
}