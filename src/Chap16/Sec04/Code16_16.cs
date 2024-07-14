using Gushwell.Utilities;

public static class Code16_16 {
    public static void Run() {
        var dt = DateTime.Now;
        Console.WriteLine(dt.ToJapaneseDateString());
        Console.WriteLine(dt.ToJapaneseDateString("yy-MM-dd"));
    }
}