
Exercise1();
Console.WriteLine("---");
Exercise2();
Console.WriteLine("---");
Exercise3();

static void Exercise1() {
    var line = Console.ReadLine();
    if (int.TryParse(line, out var num)) {
        if (num < 0) {
            Console.WriteLine(num);
        } else if (num < 100) {
            Console.WriteLine(num * 2);
        } else if (num < 500) {
            Console.WriteLine(num * 3);
        } else {
            Console.WriteLine(num);
        }
    } else {
        Console.WriteLine("入力値に誤りがあります");
    }
}

static void Exercise2() {
    var line = Console.ReadLine();
    if (int.TryParse(line, out var num)) {
        switch (num) {
            case < 0:
                Console.WriteLine(num);
                break;
            case < 100:
                Console.WriteLine(num * 2);
                break;
            case < 500:
                Console.WriteLine(num * 3);
                break;
            default:
                Console.WriteLine(num);
                break;
        }
    } else {
        Console.WriteLine("入力値に誤りがあります");
    }
}

static void Exercise3() {
    var line = Console.ReadLine();
    if (int.TryParse(line, out var num)) {
        var text = num switch {
            < 0 => num,
            < 100 => num * 2,
            < 500 => num * 3,
            _ => num
        };
        Console.WriteLine(text);
    } else {
        Console.WriteLine("入力値に誤りがあります");
    }
}

