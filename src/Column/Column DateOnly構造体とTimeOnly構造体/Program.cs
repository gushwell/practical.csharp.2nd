var date = new DateOnly(2023, 3, 26);
var date2 = date.AddMonths(3).AddDays(10);    //- ３ヶ月10日後を求める
Console.WriteLine($"{date:yyyy年MM月dd日}");
// DateTime型からDateOnly型へ変換する」
var today = DateOnly.FromDateTime(DateTime.Now);  
if (date2 < today) {   //- 日付の比較
    Console.WriteLine($"{date2} < {today}");
}

var time = new TimeOnly(7, 23);   //- 7:23で初期化する
var time2 = time.AddMinutes(20);  //- 20分後を求める
var time3 = time.AddHours(18);    //- 18時間後を求める
Console.WriteLine($"{time2}");
Console.WriteLine($"{time3}");
// DateTime型からTimeOnly型に変換する
var now = TimeOnly.FromDateTime(DateTime.Now);  
if (time < now) {  //- 時刻を比較する
    Console.WriteLine($"{time} < {now}");
}