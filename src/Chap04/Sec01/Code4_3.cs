public static class Code4_3 {
    public static void Good() {
        string[] langs = ["C#", "VB", "C++",];
        List<int> nums = [10, 20, 30, 40,];

        foreach (var lang in langs)
            Console.WriteLine(lang);

        foreach (var n in nums)
            Console.WriteLine(n);
    }

}