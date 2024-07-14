// Code 2-2
using System;

// フィートからメートルへの対応表を出力
for (int feet = 1; feet <= 10; feet++) {
    double meter = FeetToMeter(feet);
    Console.WriteLine($"{feet}ft = {meter:0.0000}m");
}

// フィートからメートルを求める
double FeetToMeter(int feet) {
    return feet * 0.3048;
}
