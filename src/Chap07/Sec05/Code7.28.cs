public static class Code7_28 {
    public static void Run() {
        var text = "The quick brown fox jumps over the lazy dog";
        var words = text.Split(' ');
        var word = words.FirstOrDefault(x => x.Length == 4);
        Console.WriteLine(word);
    }

    public static void NotRecomended() {
        var text = "The quick brown fox jumps over the lazy dog";
        var words = text.Split(' ');
        var word = words.Where(x => x.Length == 4).FirstOrDefault();
        Console.WriteLine(word);
    }

}