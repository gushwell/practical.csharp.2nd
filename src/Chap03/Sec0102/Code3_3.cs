// ここではソースファイルを分割する都合上、partial クラスを利用している
public static partial class DelegateSample {

    public delegate bool Judgement(int value);  //- デリゲートの宣言 

    static int Count(int[] numbers, Judgement judge) {
        var count = 0;
        foreach (var n in numbers) {
            if (judge(n) == true) { //- 引数で受け取ったメソッドを呼び出す
                count++;
            }
        }
        return count;
    }
}