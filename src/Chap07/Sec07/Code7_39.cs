public static class Code7_39 {
    public static void Run() {
        var words = new List<string> { "Microsoft", "Apple", "Google", "Amazon", "Meta", };
        var lowers = words
            .Select(name => name.ToLower())
            .ToArray();
        lowers.ToList().ForEach(Console.WriteLine);
    }

    static void Other() {
        var numbers = new List<int> { 8, 20, 15, 48, 2 };
        var strings = numbers
            .Select(n => n.ToString("0000"))
            .ToArray();
        strings.ToList().ForEach(Console.WriteLine);

    }
}