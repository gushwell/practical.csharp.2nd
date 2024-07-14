public static class Code7_11 {
    public static void Run() {
        var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };

        var sum = numbers.Sum();    //- numbersコレクションの要素の合計
        Console.WriteLine(sum);

        var books = Books.GetBooks();
        var totalPrice = books.Sum(x => x.Price);  //- Priceプロパティ値の合計
        Console.WriteLine(totalPrice);
    }
}