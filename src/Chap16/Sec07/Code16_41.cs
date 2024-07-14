public class Code16_41 {
    public static void Run() {
        int[] numbers = [1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89];
        Console.WriteLine(numbers is [1, 1, 2, ..]);
        Console.WriteLine(numbers is [.., 55, 89]);
        Console.WriteLine(numbers is [1, .., 89]);
        Console.WriteLine(numbers is [0, 1, .., 89]);
    }

}