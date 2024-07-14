using Code1_5;

static class RefSample {
    public static void Run() {
        // Code 1-6
        MyPoint a = new MyPoint(10, 20);
        MyPoint b = a;
        Console.WriteLine($"a: ({a.X},{a.Y})");
        Console.WriteLine($"b: ({b.X},{b.Y})");
        a.X = 80;
        Console.WriteLine($"a: ({a.X},{a.Y})");
        Console.WriteLine($"b: ({b.X},{b.Y})");
    }

}
