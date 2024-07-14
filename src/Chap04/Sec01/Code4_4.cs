public static class Code4_4 {
    public static void Good() {
        var dict = new Dictionary<string, string>() {
            ["ja"] = "日本語",
            ["en"] = "英語",
            ["es"] = "スペイン語",
            ["de"] = "ドイツ語",
        };

        foreach (var item in dict)
            Console.WriteLine($"{item.Key} {item.Value}");
    }
}