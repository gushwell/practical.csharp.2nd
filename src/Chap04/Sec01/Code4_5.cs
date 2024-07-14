public static class Code4_5 {
    public static void Good() {
        var dict = new Dictionary<string, string>() {
            { "ja", "日本語" },
            { "en", "英語" },
            { "es", "スペイン語" },
            { "de", "ドイツ語" },
        };

        foreach (var item in dict)
            Console.WriteLine($"{item.Key} {item.Value}");
    }

    public static void Bad() {
        var dict = new Dictionary<string, string>();
        dict["ja"] = "日本語";
        dict["en"] = "英語";

    }
}