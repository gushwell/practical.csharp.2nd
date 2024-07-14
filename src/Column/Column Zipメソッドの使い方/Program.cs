var jWeeks = new List<string> {
    "月", "火", "水", "木", "金", "土", "日"
};
var eWeeks = new List<string> {
    "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN"
};
var weeks = jWeeks.Zip(eWeeks, (s1, s2) => $"{s1}({s2})");
weeks.ToList().ForEach(Console.WriteLine);