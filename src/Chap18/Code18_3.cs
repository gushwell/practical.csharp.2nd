
public class Code18_3 {
    static int SampleCode() {
        int year = GetYear();
        int month = GetMonth();
        var isValid = Validate(year, month);
        // 年と月の2つの情報を返したいのでint型に詰め込む
        // エラーのときには、-1を返す
        int yearmonth = isValid ? year * 100 + month : -1;
        return yearmonth;
    }

    // 以下は単にビルドエラーにならないためのコード。
    static int GetYear() => 2004;
    static int GetMonth() => 3;

    static bool Validate(int year, int month) {
        return true;
    }
}