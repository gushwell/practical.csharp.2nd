public class Code16_37 {
    public static void Run() {
        var mp = MidPoint([2, 3, 5, 8, 9, 15, 19]);
        Console.WriteLine(mp);
    }

    static T MidPoint<T>(IEnumerable<T> sequence) {
        switch (sequence) {
            case IList<T> list:
                // 配列もIList<T>を実装している
                return list[list.Count / 2];
            default:
                int halfLength = sequence.Count() / 2 - 1;
                if (halfLength < 0)
                    halfLength = 0;
                return sequence.Skip(halfLength).First();
        };
    }
}