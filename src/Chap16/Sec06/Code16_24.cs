using System.Text;


public static class Code16_24 {
    public static void Run() {
        (int, double) tuple = (10, 15.9);
        Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");
    }
}

