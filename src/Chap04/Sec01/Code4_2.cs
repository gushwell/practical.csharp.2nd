public static class Code4_2 {
    public static void Good() {
        var langs = new[] { "C#", "VB", "C++", };
        var nums = new List<int> { 10, 20, 30, 40, };

        foreach (var lang in langs)
            Console.WriteLine(lang);

        foreach (var n in nums)
            Console.WriteLine(n);
    }

    public static void Bad() {
        var langs = new string[3];
        langs[0] = "C#";
        langs[1] = "VB";
        langs[2] = "C++";

        var nums = new List<int>();
        nums.Add(10);
        nums.Add(20);
        nums.Add(30);
        nums.Add(40);
    }
}