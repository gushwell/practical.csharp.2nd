var obj = new MySample();
await obj.RunAsync();


public class MySample {
    public async Task RunAsync() {
        var obj = new LockSample();
        var task1 = Task.Run(() => obj.DoSomething(1));
        var task2 = Task.Run(() => obj.DoSomething(2));
        var task3 = Task.Run(() => obj.DoSomething(3));
        var task4 = Task.Run(() => obj.DoSomething(4));
        var num1 = await task1;
        var num2 = await task2;
        var num3 = await task3;
        var num4 = await task4;
        Console.WriteLine($"{num1} {num2} {num3} {num4}");

    }
}

public class LockSample {
    private static object _lockObject = new Object();  //- どんな場合でもObject固定でよい

    private int _data;  //- 複数のスレッドから参照される変数

    // 並列処理するメソッド
    public int DoSomething(int no) {
        Console.WriteLine($"Enter {no}");
        lock (_lockObject) {  //- _lockObjectを排他ロック
                              //…  // ここで、_dataにアクセス
            Console.WriteLine($"Start {no}");
            Task.Delay(1000).Wait();
            _data++;
        }
        Console.WriteLine($"End {no}");
        return _data;                   //- _lockObjectを解放
                                        //…
    }

}
