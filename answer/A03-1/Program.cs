// Lust 2-26
var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };


// 3.1.1
Exercise1(numbers);
Console.WriteLine("-----");

// 3.1.2
Exercise2(numbers);
Console.WriteLine("-----");

// 3.1.3
Exercise3(numbers);
Console.WriteLine("-----");

// 3.1.4
Exercise4(numbers);

static void Exercise1(List<int> numbers) {
    var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
    if (exist)
        Console.WriteLine("存在しています");
    else
        Console.WriteLine("存在していません");
}

static void Exercise2(List<int> numbers) {
    numbers.ForEach(n => Console.WriteLine(n / 2.0));
}

static void Exercise3(IEnumerable<int> numbers) {
    foreach (var n in numbers.Where(x => x >= 50)) {
        Console.WriteLine(n);
    }
}

static void Exercise4(IEnumerable<int> numbers) {
    var list = numbers
        .Select(n => n * 2)
        .ToList();
    foreach (var n in list) {
        Console.WriteLine(n);
    }
}