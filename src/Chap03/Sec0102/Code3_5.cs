public static partial class DelegateSample {

    public static void Do2() {
        // Code 3-5
        var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
        var count = Count(numbers, IsEven);  //- IsEvenを直接渡している
        Console.WriteLine(count);
    }

    // IsEvenはCode3_4.csで定義済み

}