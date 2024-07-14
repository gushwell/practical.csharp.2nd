using Gushwell.Utilities;

public static class Code16_18 {
    public static void Run() {
        List<string> strs = [ "C#", "Java", "Ruby", "", "Python", ];
        Console.WriteLine(strs.StringJoin("-"));

        //List<string?> strs = ["C#", "Java", "Ruby", null, "Python", ];
        Console.WriteLine(string.Join("-", strs));


        int[] nums = [2, 4, 6, 8, 10];
        Console.WriteLine(nums.StringJoin(", "));
        Console.WriteLine(string.Join("-", nums));
    }
}