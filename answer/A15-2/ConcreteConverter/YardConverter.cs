namespace Example.DistanceConversion;

public class YardConverter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.ToLower() == "yard" || name == UnitName;
    protected override double Ratio => 0.9144;
    public override string UnitName => "ヤード";
}
