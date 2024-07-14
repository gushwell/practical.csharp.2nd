if (args.Length == 0)
    return;
var file = args[0];
var outputPath = Numbering(file);

Display(outputPath);

static string Numbering(string file) {
    var lines = File.ReadLines(file)
                    .Select((s, n) => string.Format("{0,4}: {1}", n + 1, s));
    var path = Path.ChangeExtension(file, ".txt");
    File.WriteAllLines(path, lines);
    return path;
}

// 確認用コード（これは無くて良い）
static void Display(string outputPath) {
    var text = File.ReadAllText(outputPath);
    Console.WriteLine(text);
}
