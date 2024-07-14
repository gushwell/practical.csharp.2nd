using System.Text.RegularExpressions;

public class Code13_15 {
    public static void Run() {
        var groups = Library.Categories
            .GroupJoin(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new {
                    Category = c.Name,
                    Count = books.Count(),
                    Average = books.Average(b => b.Price)
                });
        foreach (var obj in groups) {
            Console.WriteLine($"{obj.Category} 冊数:{obj.Count} 平均価格:{obj.Average:0.0}円");
        }
    }
}
