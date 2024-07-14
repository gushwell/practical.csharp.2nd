public static class Code6_17 {
    public static void Run() {
        var target = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        var bestWork = GetBestWork(target);
        Console.WriteLine(bestWork);
    }

    static string GetBestWork(string line) {
        var value = "BestWork=";
        var startIndex = line.IndexOf(value) + value.Length;
        var endIndex = line.IndexOf(";", startIndex);
        return line.Substring(startIndex, endIndex - startIndex);
    }

    public static void Bad() {
        var target = "Novelist=谷崎潤一郎;BestWork=春琴抄";
        var index = target.IndexOf("BestWork=") + 9;　//- 9はマジックナンバー
        var bestWork = target.Substring(index);
        Console.WriteLine(bestWork);
    }

}