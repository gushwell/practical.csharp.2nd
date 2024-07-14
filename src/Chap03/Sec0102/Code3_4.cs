public static partial class DelegateSample {

    public static void Do1() {
        // Code 3-4
        var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
        Judgement judge = IsEven;  //- IsEvenメソッドを代入 
        int count = Count(numbers, judge);
        Console.WriteLine(count);

    }

    // nが偶数かどうかを調べる
    static bool IsEven(int n) {
        return n % 2 == 0;
    }

}