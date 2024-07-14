using System.Text;

var text = "Jackdaws love my big sphinx of quartz";

Console.WriteLine("6.3.1");
Exercise1(text);

Console.WriteLine("6.3.2");
Exercise2(text);

Console.WriteLine("6.3.3");
Exercise3(text);

Console.WriteLine("6.3.4");
Exercise4(text);

Console.WriteLine("6.3.5");
Exercise5(text);


// 6.3.1
static void Exercise1(string text) {
    var spaces = text.Count(c => c == ' ');
    Console.WriteLine("空白数:{0}", spaces);
}

// 6.3.2
static void Exercise2(string text) {
    var replaced = text.Replace("big", "small");
    Console.WriteLine(replaced);
}

// 6.3.3
static void Exercise3(string text) {
    var array = text.Split(' ')
                    .ToArray();
    if (array.Length > 0) {
        var sb = new StringBuilder(array[0]);
        foreach (var word in array.Skip(1)) {
            sb.Append(' ');
            sb.Append(word);
        }
        var clone = sb.ToString();
        Console.WriteLine(clone);
    }
}

// 6.3.4
static void Exercise4(string text) {
    var count = text.Split(' ').Length;
    Console.WriteLine("単語数:{0}", count);
}

// 6.3.5
static void Exercise5(string text) {
    var words = text.Split(' ')
                    .Where(s => s.Length <= 4);
    foreach (var word in words)
        Console.WriteLine(word);
}

