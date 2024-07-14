// リスト15.12 DistanceConverterクラス

public class DistanceConverter {
public ConverterBase From { get; init; }
    public ConverterBase To { get; init; }

    public DistanceConverter(ConverterBase from, ConverterBase to) {
        From = from;
        To = to;
    }

    public double Convert(double value) {
        var meter = From.ToMeter(value);
        return To.FromMeter(meter);
    }
}