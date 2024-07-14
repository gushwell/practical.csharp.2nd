
public class Code18_10 {
    private static bool IsPrime(long number) {
        if (number == 1)
            return false;
        if (number == 2)
            return true;
        var boundary = (long)Math.Floor(Math.Sqrt(number));
        for (long i = 2; i <= boundary; ++i) {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}