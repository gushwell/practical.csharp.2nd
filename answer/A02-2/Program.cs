using DistanceConverter;

if (args.Length >= 1 && args[0] == "-toi")
    PrintMeterToInchList(1, 10);
else
    PrintInchToMeterList(1, 10);


// フィートからメートルへの対応表を出力
static void PrintInchToMeterList(int start, int stop) {
    for (int feet = start; feet <= stop; feet++) {
        double meter = InchConverter.ToMeter(feet);
        Console.WriteLine("{0} inch = {1:0.0000} m", feet, meter);
    }
}

// メートルからフィートへの対応表を出力
static void PrintMeterToInchList(int start, int stop) {
    for (int meter = start; meter <= stop; meter++) {
        double feet = InchConverter.FromMeter(meter);
        Console.WriteLine("{0} m = {1:0.0000} inch", meter, feet);
    }
}
