namespace Chap08;


public record MonthDay(int month, int day) {
    public int Month { get; init; } = month;
    public int Day { get; init; } = day;

}
