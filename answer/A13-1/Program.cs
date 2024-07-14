using CSharp.Sample;

Console.WriteLine("\n(2)");
Ans2();
Console.WriteLine("\n(3)");
Ans3();
Console.WriteLine("\n(4)");
Ans4();
Console.WriteLine("\n(5)");
Ans5();
Console.WriteLine("\n(6)");
Ans6();
Console.WriteLine("\n(7)");
Ans7();
Console.WriteLine("\n(8)");
Ans8();

static void Ans2() {
    var book = Library
        .Books
        .MaxBy(x => x.Price);
    Console.WriteLine(book);
}

static void Ans3() {
    var results = Library.Books
        .GroupBy(x => x.PublishedYear)
        .OrderBy(x => x.Key)
        .Select(x => new {
            PublishedYear = x.Key,
            Count = x.Count()
        });
    foreach (var item in results) {
        Console.WriteLine($"{item.PublishedYear}: {item.Count}");
    }
}

static void Ans4() {
    var books = Library.Books
        .OrderByDescending(x => x.PublishedYear)
        .ThenByDescending(x => x.Price);
    foreach (var item in books) {
        Console.WriteLine($"{item.PublishedYear}年 {item.Price}円 {item.Title}");
    }
}

static void Ans5() {
    var categoryNames = Library.Books
        .Where(x => x.PublishedYear == 2022)
        .Join(Library.Categories,
            b => b.CategoryId,
            c => c.Id,
            (b, c) => c.Name
        )
        .Distinct();
    foreach (var name in categoryNames) {
        Console.WriteLine(name);
    }
}



static void Ans6() {
    var gropus = Library.Books
        .Join(Library.Categories,
            b => b.CategoryId,
            c => c.Id,
            (b, c) => new {
//                b.CategoryId,
                CategoryName = c.Name,
                b.Title
            }
        )
        .GroupBy(x => x.CategoryName)
        .OrderBy(x => x.Key);
    foreach (var g in gropus) {
        Console.WriteLine($"# {g.Key}");
        foreach (var book in g) {
            Console.WriteLine($"   {book.Title}");
        }
    }
}

static void Ans7() {
    var gropus = Library.Categories
        .Where(x => x.Name == "Development")
        .Join(Library.Books,
            c => c.Id,
            b => b.CategoryId,
            (c, b) => new {
//                b.CategoryId,
//                CategoryName = c.Name,
                b.Title,
                b.PublishedYear
            }
        )
        .GroupBy(x => x.PublishedYear)
        .OrderBy(x => x.Key);
    foreach (var g in gropus) {
        Console.WriteLine($"# {g.Key}");
        foreach (var book in g) {
            Console.WriteLine($"   {book.Title}");
        }
    }
}

static void Ans8() {
    var categoryNames = Library.Categories
        .GroupJoin(Library.Books,
            c => c.Id,
            b => b.CategoryId,
            (c, books) => new {
                CategoryName = c.Name,
                Count = books.Count(),
                Average = books.Average(b => b.Price)
            })
        .Where(x => x.Count >= 4)
        .Select(x => x.CategoryName);
    foreach (var name in categoryNames) {
        Console.WriteLine(name);
    }
}