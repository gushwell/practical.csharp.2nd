public class Code18_27 {
    static void SampleCode() {
        try {
            //  …
        } catch (FileNotFoundException ex) {
            throw new MyAppException("ファイルが見つかりませんでした。", ex);
        }
    }

    // 単にビルドエラーを消すためのコード
    public class MyAppException : Exception {
        public MyAppException(string message) : base(message) {

        }


        public MyAppException(string message, Exception ex) : base(message, ex) {

        }
    }
}