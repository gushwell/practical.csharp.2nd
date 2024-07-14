using System.Collections.Immutable;

public class Code5_8 {

    public static void Run() {
        var obj = new MySample();
        // obj.MyList = new List<int>(); //- 読み取り専用なので、これはビルドエラー
        // obj.MyList[0] = 10;             // ビルドエラー
        // 変更不可のオブジェクトなので、Add, Removeは新たなインスタンスを返す
        var newList = obj.MyList.Add(6).RemoveAt(0);
        obj.MyList.ForEach(n => Console.Write($"{n} "));
        Console.WriteLine();
        newList.ForEach(n => Console.Write($"{n} "));
        Console.WriteLine();
    }

    class MySample {
        public ImmutableList<int> MyList { get; private set; }

        public MySample() {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            MyList = list.ToImmutableList();
        }
    }
}
