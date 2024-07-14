public class Code16_39 {
    public static void Run() {
        var temperature = 28;
        string tempclass = temperature switch {
            >= 35 => "猛暑日",
            >= 30 => "真夏日",
            >= 25 => "夏日",
            _ => "",
        };
        Console.WriteLine(tempclass);

    }
}