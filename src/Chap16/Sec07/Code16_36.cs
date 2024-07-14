public class Code16_36 {
    public static void Run() {
        var id = 10;
        var person = FindPerson(id);
        if (person is null) {
            Console.WriteLine("見つかりませんでした");
        }
        var person2 = FindPerson(id + 1);
        if (person2 is not null) {
            Console.WriteLine("見つかりました");
        }

    }

    static Person? FindPerson(int id) {
        return null;
    }

    record Person(string Name);
}