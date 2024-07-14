public class Code16_43 {
    public static void Run() {
        var temperature = new Temperature(-1, 12);
        var text = temperature switch {
            { Min: _, Max: >= 35 } => "猛暑日",
            { Min: _, Max: >= 30 } => "真夏日",
            { Min: _, Max: >= 25 } => "夏日",
            { Min: _, Max: < 0 } => "真冬日",
            { Min: < 0, Max: _ } => "冬日",
            _ => ""
        };
        Console.WriteLine(text);
    }

    public record Temperature(double Min, double Max);
}