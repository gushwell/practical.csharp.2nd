public static class Code7_15 {
    public static void Run() {
        List<int> numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, 8, -1, 6, 4 };
        int min = int.MaxValue;
        foreach (int n in numbers) {
            if (n <= 0) {
                continue;     //- 0以下ならば対象外なので次の処理へ
            }
            if (n < min) {
                min = n;
            }
        }                     // ループから抜けるとminに最小値が入っている
        Console.WriteLine(min);
    }
}