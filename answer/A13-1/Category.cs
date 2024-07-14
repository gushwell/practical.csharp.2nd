namespace CSharp.Sample;

public class Category {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public override string ToString() {
        return $"Id:{Id}, カテゴリ名:{Name}";
    }
}
