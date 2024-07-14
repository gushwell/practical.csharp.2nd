public class Code16_7 {

    public static void Run() {
        PrintList([1, 2, 3, 4, 5]);
        PrintList<string>(["Microsoft", "Google", "Apple", "Meta"]);

    }
    static void PrintList<T>(IEnumerable<T> list) {
        foreach (var n in list) {
            Console.WriteLine(n);
        }

    }

}
