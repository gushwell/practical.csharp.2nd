public class Code16_40 {
    public static void Run() {
        List<int> numbers = [1, 3, 5];

        if (numbers is [1, var second, _]) {
            Console.WriteLine($"要素の数は3で、1番目の要素は1で、2番目の要素は{second}です");
        }
    }

}