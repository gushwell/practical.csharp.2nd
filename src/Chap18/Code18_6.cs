using System.Text;
using System.Text.RegularExpressions;

public class Code18_6 {
    private string[] GetUpperWords(string path) {
        var list = new List<string>();
        if (String.Compare(Path.GetExtension(path), ".txt", ignoreCase: true) == 0) {
            if (File.Exists(path)) {
                using (var reader = new StreamReader(path, Encoding.UTF8)) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line)) {
                            var matches = Regex.Matches(line, @"\b\w{2,}\b");
                            foreach (Match match in matches) {
                                var word = match.Value;
                                if (word.All(c => char.IsUpper(c)))
                                    list.Add(word);
                            }
                        }
                    }
                }
            }
        }
        return list.ToArray();
    }
}