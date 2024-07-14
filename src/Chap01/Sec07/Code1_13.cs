class Code1_13 {
    public static void Run() {
        int? number = null;    //- 型名に続けて?を付けるとnull許容型になる

        if (number.HasValue) {     //- HasValueプロパティでnull以外の値が設定されているか調べることができる
            Console.WriteLine($"num = {number.Value}"); //- Valueプロパティで値を取り出せる
        } else {
            Console.WriteLine("num = null");
        }

    }
}