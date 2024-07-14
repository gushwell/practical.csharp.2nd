
public static class Code16_25 {
    public static void Run() {
        var range = FindMinMax([5, 1, 9, 3]);
        var (minimum, maximum) = range;
        Console.WriteLine($"{minimum}, {maximum}");
    }

    // 16.26
    private static (int, int) FindMinMax(IEnumerable<int> input) {
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
