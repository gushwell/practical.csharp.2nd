public static class Code3_8 {
    // List3.8
    public static void DeferredSample() {
        string[] cities = {
            "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra",
        };
        var query = cities.Where(s => s.Length <= 5);    //- query変数に代入
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