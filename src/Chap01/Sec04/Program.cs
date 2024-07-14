Run1();
Run2();

static void Run1() {
    DateTime today = DateTime.Today;
    Console.WriteLine($"今日は{today.Month}月{today.Day}日です");
}

static void Run2() {
    // 2001/10/25は今日の日付を求めるための仮の日付（何でもよい）
    // とりあえずインスタンス生成
    DateTime date = new DateTime(2001, 10, 25);

    // DateTime today = date.Today;  // Error

    // Console con = new Console();　　// Error

}


