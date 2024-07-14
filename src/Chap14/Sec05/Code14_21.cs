using System.Diagnostics;

public class Code14_21 {

    // Code 14.21
    public static async Task Run() {
        var sw = Stopwatch.StartNew();
        var tasks = new Task<int>[] {
            Task.Run(() => Get5000thPrime()),
            Task.Run(() => Get6000thPrime()),
        };
        var results = await Task.WhenAll(tasks);
        sw.Stop();
        foreach (var prime in results)
            Console.WriteLine(prime);
        Console.WriteLine($"実行時間: {sw.ElapsedMilliseconds}ミリ秒");
    }

    // 番号なし
    public static void Run2() {
        var sw = Stopwatch.StartNew();
        var prime1 = Get5000thPrime();
        var prime2 = Get6000thPrime();
        sw.Stop();
        Console.WriteLine(prime1);
        Console.WriteLine(prime2);
        Console.WriteLine($"実行時間: {sw.ElapsedMilliseconds}ミリ秒");
    }

    // 5000番目の素数を求める
    private static int Get5000thPrime() {
        return GetPrimes().Skip(4999).First();
    }

    // 6000番目の素数を求める
    private static int Get6000thPrime() {
        return GetPrimes().Skip(5999).First();
    }

    // 上記2つのメソッドから呼び出される下位メソッド
    // あえて効率の悪いアルゴリズムで記述している
    public static IEnumerable<int> GetPrimes() {
        for (int i = 2; i < int.MaxValue; i++) {
            bool isPrime = true;
            for (int j = 2; j < i; j++) {
                if (i % j == 0) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                yield return i;
        }
    }
}