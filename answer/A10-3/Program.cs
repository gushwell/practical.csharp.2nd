using System.Text;

if (args.Length <= 1)
    return;
// file1の後ろに、file2の内容を追加する。
var file1 = args[0];
var file2 = args[1];
Concat(file1, file2);

Display(file1);


// これが一番簡潔なコード。
// 調べれば、きっと簡単な方法が見つかる！
static void Concat(string file1, string file2) {
    File.AppendAllLines(file1, File.ReadLines(file2));
}

// こんな書き方もできる
static void Concat2(string file1, string file2) {
    using (var dest = new StreamWriter(file1, append: true, encoding: Encoding.UTF8)) {
        var lines = File.ReadLines(file2);
        foreach (var line in lines)
            dest.WriteLine(line);
    }
}

// 確認用コード
static void Display(string outputPath) {
    var text = File.ReadAllText(outputPath);
    Console.WriteLine(text);
}