var animals1 = new[] { "キリン", "ライオン", "ゾウ", "シロクマ", "パンダ", };
var animals2 = new[] { "ライオン", "コアラ", "キリン", "ゴリラ", };

List<Category> categories1 = [
    new Category { Id = 2, Name = "Server" },
    new Category { Id = 3, Name = "Web Design" },
];
List<Category> categories2 = [
    new Category{ Id = 1, Name = "Development" },
    new Category{ Id = 3, Name = "Web Design" },
    new Category{ Id = 4, Name = "Windows" },
]; 

// 和集合
{
    var union = animals1.Union(animals2);
    Console.WriteLine(string.Join(" ", union));
}


// 和集合
{
    var categories = categories1
        .UnionBy(categories2, x => x.Id);
    foreach (var category in categories) {
        Console.WriteLine($"{category.Id} {category.Name}");
    }
}

// 積集合
{
    var intersect = animals1.Intersect(animals2);
    Console.WriteLine(string.Join(" ", intersect));

}

// 積集合
{
    var categories = categories1
        .IntersectBy(categories2.Select(x => x.Id), x => x.Id);
    foreach (var category in categories) {
        Console.WriteLine($"{category.Id} {category.Name}");
    }

}

// 差集合
{
    var expect = animals1.Except(animals2);
    Console.WriteLine(string.Join(" ", expect));
}

// 差集合
{
    var categories = categories1
        .ExceptBy(categories2.Select(x => x.Id), x => x.Id);
    foreach (var category in categories) {
        Console.WriteLine($"{category.Id} {category.Name}");
    }

}


public class Category {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
