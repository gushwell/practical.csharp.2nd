using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine(Path.GetFullPath(args[0]));

// 2回目の読み込みは、ファイルの内容がバッファーにたまっているために、必然的に速度が速くなる
// そのため、一度読み込んでからの時間を計測する。
// コア数の少ないCPUだと、実行環境によっては、並列版のほうが遅くなる場合もある。

var obj = new ParallelAndSerialSample();
// これはダミーの読み込み
obj.SerialExecute(args[0]);

// ここからが実際の計測
Console.WriteLine("並列版を実行します。Enterキーを押してください");
Console.ReadLine();
var parallelTime = await obj.ParallelExecuteAsync(args[0]);

Console.WriteLine("非並列版を実行します。Enterキーを押してください");
Console.ReadLine();
var serialTime = obj.SerialExecute(args[0]);

Console.WriteLine("並列版（実行数制限版）を実行します。Enterキーを押してください");
Console.ReadLine();
var parallelTimeWithLimit = await obj.ParallelExecuteWithLimitAsync(args[0]);

Console.WriteLine($"並列版 {parallelTime.TotalSeconds}");
Console.WriteLine($"非並列版 {serialTime.TotalSeconds}");
Console.WriteLine($"並列版（実行数制限版） {parallelTimeWithLimit.TotalSeconds}");

class ParallelAndSerialSample {
#pragma warning disable CS1998 // 並列実行のためこの警告は無視
    // 並列版
    public async Task<TimeSpan> ParallelExecuteAsync(string dir) {
        var start = DateTime.Now;
        var files = Directory.EnumerateFiles(dir, "*.cs", SearchOption.AllDirectories);
        var tasks = new List<Task>();
        foreach (var file in files) {
            tasks.Add(Task.Run(async () => {
                if (Find(file))
                    Console.WriteLine(Path.GetFullPath(file));
            }));
        }
        await Task.WhenAll(tasks);
        return DateTime.Now - start;
    }
#pragma warning restore CS1998 // 非同期メソッドは、'await' 演算子がないため、同期的に実行されます

    // 非並列版
    public TimeSpan SerialExecute(string dir) {
        var start = DateTime.Now;
        var files = Directory.EnumerateFiles(dir, "*.cs", SearchOption.AllDirectories);
        foreach (var file in files) {
            if (Find(file))
                Console.WriteLine(Path.GetFullPath(file));
        }
        return DateTime.Now - start;
    }

    private bool Find(string file) {
        bool useAsync = false;
        bool useAwait = false;
        foreach (var line in File.ReadLines(file)) {
            if (Regex.IsMatch(line, @"\basync\b"))
                useAsync = true;
            if (Regex.IsMatch(line, @"\bawait\b"))
                useAwait = true;
            if (useAsync && useAwait)
                return true;
        }
        return false;
    }

#pragma warning disable CS1998 // 並列実行のためこの警告は無視
    // 並列版 おまけ
    public async Task<TimeSpan> ParallelExecuteWithLimitAsync(string dir) {
        // 同時実行数が多すぎるとかえって遅くなる場合がある。（実行環境や読み込むファイルの内容に依存する）
        // 以下の行で同時に実行するスレッド数を制限する。
        var semaphore = new SemaphoreSlim(6);

        var start = DateTime.Now;
        var files = Directory.EnumerateFiles(dir, "*.cs", SearchOption.AllDirectories);
        var tasks = new List<Task>();
        foreach (var file in files) {
            var task = Task.Run(async () => {
                // セマフォの利用開始
                await semaphore.WaitAsync(); 
                try {
                    if (Find(file))
                        Console.WriteLine(Path.GetFullPath(file));
                } finally {
                    // セマフォの利用終了
                    semaphore.Release(); 
                }
            });
            tasks.Add(task);
        }
        await Task.WhenAll(tasks);
        return DateTime.Now - start;
    }
#pragma warning restore CS1998 // 非同期メソッドは、'await' 演算子がないため、同期的に実行されます

}
