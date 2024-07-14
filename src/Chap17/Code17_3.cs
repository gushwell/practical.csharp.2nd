
public class Code17_3 {
    public static void Run() {
        int year = 2024;
        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            Console.WriteLine("閏年");
    }
}
