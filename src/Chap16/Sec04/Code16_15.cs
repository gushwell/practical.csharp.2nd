namespace Gushwell.Utilities;

public static class DateTimeExtension {
    public static string ToJapaneseDateString(this DateTime date, string format = "") {
        var jp = new System.Globalization.CultureInfo("ja-JP");
        jp.DateTimeFormat.Calendar =
            new System.Globalization.JapaneseCalendar();
        if (format == string.Empty) {
            return date.ToString("ggyy年MM月dd日(ddd)", jp);
        } else {
            return date.ToString(format, jp);
        }
    }
}
