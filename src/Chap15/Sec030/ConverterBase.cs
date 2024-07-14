//  リスト15.10 ConverterBaseクラス

public abstract class ConverterBase {
    // メートルとの比率（この比率を掛けるとメートルに変換できる）
    protected abstract double Ratio { get; }

    // 距離の単位名（たとえば、"メートル"、"フィート"など）
    public abstract string UnitName { get; }

    // メートルからの変換
    public double FromMeter(double meter) => meter / Ratio;

    // メートルへの変換
    public double ToMeter(double feet) => feet * Ratio;
}