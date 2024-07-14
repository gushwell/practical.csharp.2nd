public static class Code3_9 {

    // List3.9
    public static void ImmediateQuery() {
        string[] cities = {
            "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra",
        };
        var query = cities
            .Where(s => s.Length <= 5)
            .ToArray();//- ここで配列に変換 
        foreach (var item in query) {
            Console.WriteLine(item);
        }
        Console.WriteLine("------");

        cities[0] = "Osaka";            //- cities[0]を変更 
        foreach (var item in query) {   //- 再度、queryの内容を取り出す 
            Console.WriteLine(item);
        }
    }
}