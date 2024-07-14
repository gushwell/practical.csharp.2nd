public static class Code8_1 {
    public static void Run() {
        var flowerDict = new Dictionary<string, int>() {
            { "sunflower", 400 },
            { "pansy", 300 },
            { "tulip", 350 },
            { "rose", 500 },
            { "dahlia", 450 },
        };
        Console.WriteLine(flowerDict["sunflower"]);
        Console.WriteLine(flowerDict["dahlia"]);

    }
}
