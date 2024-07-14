public static class Code6_29 {
    public static void Run() {
        var text = "The quick brown fox jumps over the lazy dog.";
        string[] words = text.Split(' ');
        foreach (var word in words) {
            Console.Write(word + ", ");
        }
        Console.WriteLine();
    }
}