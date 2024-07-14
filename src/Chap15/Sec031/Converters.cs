// リスト15.14 ConverterBaseの派生クラス

public class MeterConverter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.ToLower() == "meter" || name == UnitName;

    protected override double Ratio => 1;
    public override string UnitName => "メートル";
}

public class FeetConverter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.ToLower() == "feet" || name == UnitName;
    protected override double Ratio => 0.3048;
    public override string UnitName => "フィート";
}

public class InchConverter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.ToLower() == "inch" || name == UnitName;
    protected override double Ratio => 0.0254;
    public override string UnitName => "インチ";
}

public class YardConverter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.ToLower() == "yard" || name == UnitName;
    protected override double Ratio => 0.9144;
    public override string UnitName => "ヤード";
}