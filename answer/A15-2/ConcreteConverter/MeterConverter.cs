namespace Example.DistanceConversion;

public class MeterConverter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.ToLower() == "meter" || name == UnitName;

    protected override double Ratio => 1;
    public override string UnitName => "メートル";
}
