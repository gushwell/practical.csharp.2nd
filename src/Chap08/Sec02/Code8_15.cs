using Chap08;

public static class Code8_15 {
    public static void Run() {
        var lines = File.ReadAllLines("sample.txt");
        var we = new WordsExtractor(lines);
        foreach (var word in we.Extract()) {
            Console.WriteLine(word);
        }
    }
}
