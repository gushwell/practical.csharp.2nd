public class Code16_8 {

    public static void Run() {
        var n = DoSomething([1, 2, 3, 3, 4, 5, 5, 6]);
        Console.WriteLine(n);

        var s = DoSomething(["123", "345"]);
        Console.WriteLine(s ?? "<null>");

    }
    static T? DoSomething<T>(IList<T> list) where T : notnull {
        for (int i = 0; i < list.Count - 1; i++)
            if (list[i].Equals(list[i + 1])) {
                return list[i];
            }
        return default;
    }

}
