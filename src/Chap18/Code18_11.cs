
public class Code18_11 {
    private static bool IsPrime(long number) {
        bool isPrime = false;
        if (number == 1)
            isPrime = false;
        else if (number == 2)
            isPrime = true;
        else {
            var boundary = (long)Math.Floor(Math.Sqrt(number));
            for (long i = 2; i <= boundary; ++i) {
                if (number % i == 0) {
                    isPrime = false;
                    break;
                }
            }
        }
        return isPrime;
    }
}