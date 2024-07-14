
public static class Code5_4 {

    public static void Run() {
        var person = new Person("佐藤", "涼子");
        //person.GivenName = "涼介";     //- これはビルドエラーになる
        //person.FamilyName = "細川";     //- これはビルドエラーになる
        person.ChangeFamilyName("橋本");
        Console.WriteLine($"{person.FamilyName} {person.GivenName}");
    }

    public class Person {
        public string GivenName { get; private set; }

        public string FamilyName { get; private set; }

        public Person(string familyName, string givenName) {
            FamilyName = familyName;
            GivenName = givenName;
        }

        // メソッド内でプロパティの値を変更できる。
        public void ChangeFamilyName(string name) {
            FamilyName = name;
        }
    }

}
