public static class Code7_30 {
    public static void Run() {
        var numbers = new List<int> { 9, 7, -5, -4, 2, 5, 4, 0, -4, 8, -1, 0, 4 };
        var item = numbers
            .Select((n, ix) => new { Value = n, Index = ix })
            .FirstOrDefault(o => o.Value < 0);
        var index = item?.Index ?? -1;
        Console.WriteLine(index);
    }

    public static void Other() {
        var numbers = new List<int> { 9, 7, -5, -4, 2, 5, 4, 0, -4, 8, -1, 0, 4 };
        var item = numbers
            .Select((n, ix) => new { n, ix }) //- nは要素、ixは要素に対応するインデックス
            .FirstOrDefault(o => o.n < 0);
        var index = item?.ix ?? -1;
        Console.WriteLine(index);
    }
}