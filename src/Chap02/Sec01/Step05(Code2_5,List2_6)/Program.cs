// Code 2-6
using System;

using DistanceConverter;

if (args.Length >= 1 && args[0] == "-tom") {
    PrintFeetToMeterList(1, 10);
} else {
    PrintMeterToFeetList(1, 10);
}

// フィートからメートルへの対応表を出力
static void PrintFeetToMeterList(int start, int stop) {
    FeetConverter converter = new FeetConverter();
    for (int feet = start; feet <= stop; feet++) {
        double meter = converter.ToMeter(feet);
        Console.WriteLine($"{feet}ft = {meter:0.0000}m");
    }
}

// メートルからフィートへの対応表を出力
static void PrintMeterToFeetList(int start, int stop) {
    FeetConverter converter = new FeetConverter();
    for (int meter = start; meter <= stop; meter++) {
        double feet = converter.FromMeter(meter);
        Console.WriteLine($"{meter}m = {feet:0.0000}ft");
    }
}

