// リスト15.11 ConverterBaseクラスの具象クラス

public class MeterConverter : ConverterBase {
    protected override double Ratio => 1;
    public override string UnitName => "メートル";
}

public class FeetConverter : ConverterBase {
    protected override double Ratio => 0.3048;
    public override string UnitName => "フィート";
}

public class InchConverter : ConverterBase {
    protected override double Ratio => 0.0254;
    public override string UnitName => "インチ";
}

public class YardConverter : ConverterBase {
    protected override double Ratio => 0.9144;
    public override string UnitName => "ヤード";
}