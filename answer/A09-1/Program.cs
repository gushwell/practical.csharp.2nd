using System.Globalization;
using System.Text.RegularExpressions;

//var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
var dateTime = DateTime.Now;
DisplayDatePattern1(dateTime);
DisplayDatePattern2(dateTime);
DisplayDatePattern3(dateTime);
DisplayDatePattern3_2(dateTime);
DisplayDatePattern3_3(dateTime);


static void DisplayDatePattern1(DateTime dateTime) {
    // 2024/03/09 19:03
    // string.Formatを使った例
    var str = string.Format($"{dateTime:yyyy/MM/dd HH:mm}");
    Console.WriteLine(str);
}

static void DisplayDatePattern2(DateTime dateTime) {
    // 2024年03月09日 19時03分09秒
    // DateTime.ToStringを使った例
    var str = dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
    Console.WriteLine(str);
}

static void DisplayDatePattern3(DateTime dateTime) {
    var culture = new CultureInfo("ja-JP");
    culture.DateTimeFormat.Calendar = new JapaneseCalendar();

    // 以下のコードは、"令和06年" とゼロサプレスされない
    var datestr = dateTime.ToString("ggyy", culture);
    var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);

    var str = string.Format($"{datestr}年{dateTime.Month,2}月{dateTime.Day,2}日({dayOfWeek})");
    Console.WriteLine(str);
    // 年も2桁固定で、ゼロサプレスする場合は、さらに工夫が必要
    // DisplayDatePattern3_2, DisplayDatePattern3_3 でその一例を示す。
}

// 10章で説明する Regexクラスを利用し、ゼロサプレスすれば、目的の結果が得られる。
// 年も2桁固定で、ゼロサプレスできる。
static void DisplayDatePattern3_2(DateTime dateTime) {
    // 次のように書いた場合、結果が異なる                
    var culture = new CultureInfo("ja-JP");
    culture.DateTimeFormat.Calendar = new JapaneseCalendar();
    // dddd で 日曜日 などの文字列を得ることができる
    var dateStr = dateTime.ToString("ggyy年MM月dd日(dddd)", culture);
    var str = Regex.Replace(dateStr, @"0(\d)", " $1");
    Console.WriteLine(str);
}

// 愚直にやるコード
// 年も2桁固定で、ゼロサプレスできる。
static void DisplayDatePattern3_3(DateTime dateTime) {
    var culture = new CultureInfo("ja-JP");
    culture.DateTimeFormat.Calendar = new JapaneseCalendar();

    var era = dateTime.ToString("gg", culture);
    var year = int.Parse(dateTime.ToString("yy", culture));
    var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);

    // 年も2桁固定で、ゼロサプレスする場合は、さらに工夫が必要
    // DisplayDatePattern3_2, DisplayDatePattern3_3 でその一例を示す。
    var str = string.Format($"{era}{year,2}年{dateTime.Month,2}月{dateTime.Day,2}日({dayOfWeek})");
    Console.WriteLine(str);
}