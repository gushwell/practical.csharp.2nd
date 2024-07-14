namespace Example.DistanceConversion;


public class FeetConverter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.ToLower() == "feet" || name == UnitName;
    protected override double Ratio => 0.3048;
    public override string UnitName => "フィート";
}
