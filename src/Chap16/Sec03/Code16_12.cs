using System.Collections;

public static class Code16_12 {
    public static void Run() {
        var evenNumbers = new MyEvenNumbers(0, 10);
        foreach (var item in evenNumbers) {
            Console.Write($"{item} ");
        }
        Console.ReadLine();
    }
}

public class MyEvenNumbers : IEnumerable<int> {
    private readonly int _start;
    private readonly int _end;

    public MyEvenNumbers(int start, int end) {
        _start = start % 2 == 0 ? start : start + 1;
        _end = end;
    }

    // IEnumerable<int> を実装するための GetEnumerator メソッド
    public IEnumerator<int> GetEnumerator() {
        for (var i = _start; i <= _end; i += 2)
            yield return i;
    }

    // IEnumerable を実装するための GetEnumerator メソッド
    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}