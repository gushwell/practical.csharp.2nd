namespace Example.DistanceConversion;

public class MileConverter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.ToLower() == "mile" || name == UnitName;
    protected override double Ratio => 1609.34;
    public override string UnitName => "マイル";
}
