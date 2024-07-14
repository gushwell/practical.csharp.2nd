public class Code5_10 {

    public static void Run() {
        var median = Median(1.0, 2.0, 3.0);
        Console.WriteLine(median);
        var median2 = Median(1.0, 2.0, 3.0, 4.0, 5.0);
        Console.WriteLine(median2);

    }

    // 中央値を求めるメソッド
    public static double Median(params double[] args) {
        var sorted = args.OrderBy(n => n).ToArray();
        var index = sorted.Length / 2;
        if (sorted.Length % 2 == 0)
            return (sorted[index] + sorted[index - 1]) / 2;
        else
            return sorted[index];
    }
}