using System.Text;

Task task = RunAsync();

// 非同期で動作しているので、ファイルを読み込んでいる間、以下のコードが動作する。
// 上記RunAsyncで呼び出したtaskが完了するまで、コンソールから入力した文字列をそのまま出力している。
// 入力待ちの状態でも、上記taskが完了すれば、ファイルの内容がコンソールに表示される。
// この時は、まだ入力が終わっていないので、コンソールから入力したら、whileループから
// 抜け出し、"Task End!"が表示される。
while (!task.IsCompleted) {
    Console.Write("=>");
    var s = Console.ReadLine();
    Console.WriteLine(s);
}
Console.WriteLine("Task End!");

static async Task RunAsync() {
    var text = await TextReaderSample.ReadTextAsync("走れメロス.txt");
    Console.WriteLine(text);
}

static class TextReaderSample {
    public static async Task<string> ReadTextAsync(string filePath) {
        var sb = new StringBuilder();
        var sr = new StreamReader(filePath);
        while (!sr.EndOfStream) {
            var line = await sr.ReadLineAsync();
            sb.AppendLine(line);
            // 非同期で動いていることがわかるように、あえて、Delayを入れている。
            await Task.Delay(80);
        }
        return sb.ToString();
    }
}