namespace Example.DistanceConversion;

public class KilometerConverter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.ToLower() == "kilometer" || name == UnitName;

    protected override double Ratio => 1000.0;
    public override string UnitName => "キロメートル";
}
