
public static class Code16_28 {
    public static void Run() {
        // 16.28
        var tuple = (sum: 24.5, count: 3);
        Console.WriteLine($"Count={tuple.count}, Sum={tuple.sum}.");

        // 16.29
        var range = FindMinMax([5, 1, 9, 3]);
        Console.WriteLine($"{range.min}, {range.max}");
    }

    private static (int min, int max) FindMinMax(IEnumerable<int> input) {
        if (!input.Any())
            throw new ArgumentException("要素がないため最小値、最大値を求められません");
        var min = int.MaxValue;
        var max = int.MinValue;
        foreach (var i in input) {
            if (i < min) {
                min = i;
            }
            if (i > max) {
                max = i;
            }
        }
        return (min, max);
    }

}
