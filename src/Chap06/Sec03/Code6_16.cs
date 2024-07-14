public static class Code6_16 {
    public static void Run() {
        var target = "Novelist=谷崎潤一郎;BestWork=春琴抄";
        var bestWork = GetBestWork(target);
        Console.WriteLine(bestWork);
    }

    static string GetBestWork(string line) {
        var value = "BestWork=";
        var index = line.IndexOf(value) + value.Length;
        return line.Substring(index);
    }
}