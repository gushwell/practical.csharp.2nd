
// 演習問題なので、意味のない名前空間になっているが、本来は適切な名前にする必要あり。
namespace CSharp.Exercise;

public record YearMonth(int Year, int Month) {
    public bool Is21Century => 2001 <= Year && Year <= 2100;

    public YearMonth AddOneMonth() {
        if (Month == 12) {
            return new YearMonth(this.Year + 1, 1);
        } else {
            return new YearMonth(this.Year, this.Month + 1);
        }
    }

    public override string ToString() => $"{Year}年{Month}月";
}

