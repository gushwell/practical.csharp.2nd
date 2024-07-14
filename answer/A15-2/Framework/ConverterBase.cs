namespace Example.DistanceConversion;

// リスト15.13 IsMyUnitを追加したConverterBaseクラス

public abstract class ConverterBase {
    // nameで与えられた単位が自分のものか判断
    public abstract bool IsMyUnit(string name);

    // メートルとの比率（この比率を掛けるとメートルに変換できる）
    protected abstract double Ratio { get; }

    // 距離の単位名（たとえば、"メートル"、"フィート"など）
    public abstract string UnitName { get; }

    // メートルからの変換
    public double FromMeter(double meter) => meter / Ratio;

    // メートルへの変換
    public double ToMeter(double feet) => feet * Ratio;
}
