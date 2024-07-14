var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

foreach (var pair in line.Split(';')) {
    var array = pair.Split('=');
    Console.WriteLine("{0}:{1}", ToJapanese(array[0]), array[1]);
}

static string ToJapanese(string key) {
    return key switch {
        "Novelist" => "作家　",
        "BestWork" => "代表作",
        "Born" => "誕生年",
        _ => throw new ArgumentException("引数keyは、正しい値ではありません"),
    };
}