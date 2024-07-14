using Chap08;

public static class Code8_16 {
    public static void Run() {
        // ディクショナリの初期化
        var dict = new Dictionary<string, List<string>>() {
            ["PC"] = new List<string> { "パーソナルコンピューター", "プログラムカウンター", },
            ["DI"] = new List<string> { "依存性の注入", "データ統合", },
        };

        // ディクショナリに追加
        var key = "EC";
        var value = "電子商取引";
        if (dict.ContainsKey(key)) {
            // "EC"が登録済みなら、"電子商取引"を追加
            dict[key].Add(value);  
        } else {
            // "EC"が未登録みなら、"電子商取引"が格納されたリストを登録
            dict[key] = new List<string> { value };
        }

        // ディクショナリの内容を列挙
        foreach (var item in dict) {
            foreach (var term in item.Value) {
                Console.WriteLine($"{item.Key} : {term}");
            }
        }
    }
}
