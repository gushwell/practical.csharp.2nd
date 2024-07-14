using System.Globalization;

public class Code9_26 {
    public static void Run() {
        var birthday = new DateTime(1992, 4, 5);
        var today = DateTime.Today;
        int age = GetAge(birthday, today); //- 1992年4月5日生まれの人が、今日何歳かを求める
        Console.WriteLine(age);
    }

    // Code 9-26
    static int GetAge(DateTime birthday, DateTime targetDay) {
        var age = targetDay.Year - birthday.Year;
        if (targetDay < birthday.AddYears(age)) {
            age--;
        }
        return age;
    }
}