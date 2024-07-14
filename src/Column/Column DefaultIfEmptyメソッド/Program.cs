{
    var numbers = new List<int> { -5, -2, -8, -12 };
    var min = numbers
        .Where(n => n > 0)
        .DefaultIfEmpty(int.MinValue)
        .Min();
    Console.WriteLine(min);
}

// 以下は例外発生
{
    var numbers = new List<int> { -5, -2, -8, -12 };
    var min = numbers
        .Where(n => n > 0)
        .Min();
    Console.WriteLine(min);
}
