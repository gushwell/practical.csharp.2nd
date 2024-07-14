
namespace CSharp.Sample;

public class Book {

    public string Title { get; set; } = string.Empty;
    public int Price { get; set; }
    public int CategoryId { get; set; }
    public int PublishedYear { get; set; }

    public override string ToString() {
        return $"発行年:{PublishedYear}, カテゴリ:{CategoryId}, 価格:{Price}, タイトル:{Title}";
    }
}

