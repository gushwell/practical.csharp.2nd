
public static class Code16_30 {
    public static void Run() {
        var num = 192;
        if (Math.DivRem(num, 4) is (Quotient: var q, Remainder: 0)) {
            Console.WriteLine($"{num}は4で割り切れます。その時の商は{q}です");
        }
    }


}
