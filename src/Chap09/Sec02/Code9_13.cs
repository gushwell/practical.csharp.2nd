using System.Globalization;

public class Code9_13 {
    public static void Run() {
        var date = new DateTime(1995, 8, 24);
        var culture = new CultureInfo("ja-JP");
        culture.DateTimeFormat.Calendar = new JapaneseCalendar();
        var era = culture.DateTimeFormat.Calendar.GetEra(date); //- 元号コードを得る
        var eraName = culture.DateTimeFormat.GetEraName(era);  //- 元号コードから元号名を得る
        Console.WriteLine(eraName);

        var abbEra = culture.DateTimeFormat.GetAbbreviatedEraName(era);
        Console.WriteLine(abbEra);
    }
}