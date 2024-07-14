using Gushwell.Utilities;

public static class Code16_23 {
    public static void Run() {
        Gender male = Gender.Male;
        Gender female = Gender.Female;
        Console.WriteLine(male.GetDisplayName()); // "男性"が表示される
        Console.WriteLine(female.GetDisplayName()); // "女性"が表示される

    }

}