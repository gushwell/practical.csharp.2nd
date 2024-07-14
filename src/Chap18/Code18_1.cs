
public class Code18_1 {
    static void PrintFeetToMeterList(int start, int stop) {
        double meter;
        int feet;
        for (feet = start; feet <= stop; feet++) {
            meter = FeetToMeter(feet);
            Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
        }
    }

    // 単にビルドエラーにならないためのコード。
    static double FeetToMeter(double feet) {
        return 0.0;
    }
}