
public static class Code16_27 {
    public static void Run() {
        var destination = string.Empty;
        var distance = 0.0;

        var d = ("〇〇市役所", 1.3);
        (destination, distance) = d;
        Console.WriteLine($"{destination} {destination}");
    }
}
