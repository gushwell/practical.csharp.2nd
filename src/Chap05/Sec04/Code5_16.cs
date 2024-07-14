

public class Code5_16 {

    public static void Run() {
        var student = new Student("井上はるか", new DateOnly(2007, 6, 14));
    }

    public class Student(string name, DateOnly birthday) {
        public string Name { get; init; } = name;
        public DateOnly Birthday { get; init; } = birthday;
    }

    // プライマリコンストラクタを使わない従来の書き方
    public class Student2 {
        public string Name { get; init; }
        public DateOnly Birthday { get; init; }

        public Student2(string name, DateOnly birthday) {
            Name = name;
            Birthday = birthday;
        }
    }

}

