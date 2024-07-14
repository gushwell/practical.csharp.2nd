public static class Code6_30 {
    public static void Run() {
        var text = "The quick brown fox jumps over the lazy dog.";
        var words = text.Split(new[] { ' ', '.' },
                                StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in words) {
            Console.Write(word + ", ");
        }
        Console.WriteLine();
    }
}