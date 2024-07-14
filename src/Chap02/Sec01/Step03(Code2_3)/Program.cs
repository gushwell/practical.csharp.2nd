// Code 2-3
using System;

if (args.Length >= 1 && args[0] == "-tom") {
    // フィートからメートルへの対応表を出力
    for (int feet = 1; feet <= 10; feet++) {
        double meter = FeetToMeter(feet);
        Console.WriteLine($"{feet}ft = {meter:0.0000}m");
    }
} else {
    // メートルからフィートへの対応表を出力
    for (int meter = 1; meter <= 10; meter++) {
        double feet = MeterToFeet(meter);
        Console.WriteLine($"{meter}m = {feet:0.0000}ft");
    }
}

// フィートからメートルを求める
static double FeetToMeter(int feet) {
    return feet * 0.3048;
}

// メートルからフィートを求める
static double MeterToFeet(int meter) {
    return meter / 0.3048;
}
