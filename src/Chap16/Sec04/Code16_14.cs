using Gushwell.Utilities;

public static class Code16_14 {
    public static void Run() {
        string text = "色は匂へど 散りぬるを";
        var base64str = text.ToBase64();
        Console.WriteLine(base64str);
        var original = base64str.FromBase64();
        Console.WriteLine(original);
    }
}