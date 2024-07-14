
public class Category {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public override string ToString() {
        return $"Id:{Id}, カテゴリ名:{Name}";
    }
}

public class Book {

    public string Title { get; set; } = string.Empty;
    public int Price { get; set; }
    public int CategoryId { get; set; }
    public int PublishedYear { get; set; }

    public override string ToString() {
        return $"発行年:{PublishedYear}, カテゴリ:{CategoryId}, 価格:{Price}, タイトル:{Title}";
    }
}

public static class Library {
    // Categoriesプロパティで上記のカテゴリの一覧を得ることができる。
    public static IEnumerable<Category> Categories { get; private set; }

    // Booksプロパティで上記の書籍情報の一覧を得ることができる。
    public static IEnumerable<Book> Books { get; private set; }

    static Library() {
        Categories = new List<Category> {
                new Category { Id = 1, Name = "Development"  },
                new Category { Id = 2, Name = "Server"  },
                new Category { Id = 3, Name = "Web Design"  },
                new Category { Id = 4, Name = "Windows"  },
                new Category { Id = 5, Name = "Application"  },
            };

        Books = new List<Book> {
            new Book {
                Title = "C#開発指南",
                CategoryId = 1,
                Price = 3800,
                PublishedYear = 2020
            },
            new Book {
                Title = "C#で作成するクラウドネイティブアプリ" ,
                CategoryId = 1 ,
                Price = 2780 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "フレーズで学ぶC# Book",
                CategoryId = 1 ,
                Price = 2400 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "TypeScript初級講座",
                CategoryId = 1 ,
                Price = 2500 ,
                PublishedYear = 2022
            },
            new Book {
                Title = "Writing C# Solid Code",
                CategoryId = 1 ,
                Price = 2500 ,
                PublishedYear = 2023
            },
            new Book {
                Title = "SQL Server 完全入門",
                CategoryId = 2 ,
                Price = 3800 ,
                PublishedYear = 2020
            },
            new Book {
                Title = "IIS Webサーバー運用ガイド",
                CategoryId = 2 ,
                Price = 3180 ,
                PublishedYear = 2020
            },
            new Book {
                Title = "PowerShell 実践レシピ",
                CategoryId = 2 ,
                Price = 4200 ,
                PublishedYear = 2022
            },
            new Book {
                Title = "Microsoft Azureサーバー構築",
                CategoryId = 2 ,
                Price = 4800 ,
                PublishedYear = 2022
            },
            new Book {
                Title = "HTML+JavaScript Web大百科",
                CategoryId = 3 ,
                Price = 3800 ,
                PublishedYear = 2020
            },
            new Book {
                Title = "CSSデザイン 逆引き辞典",
                CategoryId = 3 ,
                Price = 3550 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "続Webデザイン講座 HTML＆CSS",
                CategoryId = 3 ,
                Price = 2800 ,
                PublishedYear = 2023
            },
            new Book {
                Title = "Windows11使いこなし術",
                CategoryId = 4 ,
                Price = 1890 ,
                PublishedYear = 2020
            },
            new Book {
                Title = "Windowsで楽しくお仕事",
                CategoryId = 4 ,
                Price = 2280 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "Windowsやさしい操作入門",
                CategoryId = 4 ,
                Price = 2300 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "続Windows使いこなし術",
                CategoryId = 4 ,
                Price = 2080 ,
                PublishedYear = 2023
            },
            new Book {
                Title = "たのしく学ぶExcel初級編",
                CategoryId = 5 ,
                Price = 2800 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "Word・Excel実践テンプレート集",
                CategoryId = 5 ,
                Price = 2600 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "まるわかりMicrosoft365入門",
                CategoryId = 5,
                Price = 1890,
                PublishedYear = 2022
            },
        };
    }
}

