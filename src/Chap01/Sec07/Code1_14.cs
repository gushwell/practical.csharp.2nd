class Code1_14 {
    public static void Run() {
        // nullを許容しない
        string text = "C# Programming";
        // nullを許容する
        string? nullableText = "C# Programming";

        text = null;            //- ワーニング　（無視してはいけない）
        nullableText = null;    //- OK

    }
}