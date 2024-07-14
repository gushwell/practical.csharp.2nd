namespace Example.DistanceConversion;


public class InchConverter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.ToLower() == "inch" || name == UnitName;
    protected override double Ratio => 0.0254;
    public override string UnitName => "インチ";
}