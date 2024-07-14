public static class Code7_29 {
    public static void Run() {
        string text = "The quick brown fox jumps over the lazy dog";
        string[] words = text.Split(' ');
        string word = string.Empty;
        foreach (string w in words) {
            if (w.Length == 4) {
                word = w;
                break;
            }
        }
        Console.WriteLine(word);
    }
}