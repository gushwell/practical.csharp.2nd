
public static class Code5_3 {

    public static void Run() {
        var person = new Person("佐藤", "秀行");
        //person.GivenName = "涼介";     //- これはビルドエラーになる
    }

    public class Person {
        public string GivenName { get; init; }

        public string FamilyName { get; init; }

        // コンストラクター
        public Person(string familyName, string givenName) {
            FamilyName = familyName;
            GivenName = givenName;
        }
    }

}
