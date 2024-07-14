using System.Globalization;

public static class Code7_22 {
    public static void Run() {
        List<int> numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 11, 30, 24 };
        bool exists = false;
        foreach (int n in numbers) {
            if (n % 7 == 0) {
                exists = true;
                break;
            }
        }
        Console.WriteLine(exists);
    }
}