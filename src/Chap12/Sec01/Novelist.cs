public class Novelist {
    public string Name { get; init; } = string.Empty;

    public string[] Masterpieces { get; init; } = null!;

    public override string ToString() {
        var titles = String.Join(',', Masterpieces);
        return $"Name={Name} Masterpieces={titles}";
    }
}
