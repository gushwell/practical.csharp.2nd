public static class Code7_4 {
    public static void Run() {
        int[] numbers = new int[20];
        for (int i = 0; i < numbers.Length; i++) { //- Lengthプロパティで配列の要素数を取得できる
            numbers[i] = -1;
        }
        foreach (int num in numbers)
            Console.Write($"{num} ");
        Console.WriteLine();

    }

}