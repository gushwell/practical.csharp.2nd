public static class Code6_28 {
    public static void Run() {
        var languages = new[] { "C#", "Java", "Python", "Ruby", };
        var separator = ", ";
        var result = String.Join(separator, languages);
        Console.WriteLine(result);
    }
}