// List3.7
public static class Code3_7 {
    public static void SimpleQuery() {
        var cities = new List<string> {
            "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
            "Canberra", "Hong Kong",
        };
        IEnumerable<string> query = cities.Where(s => s.Length <= 5);
        foreach (string s in query) {
            Console.WriteLine(s);
        }
    }
}
