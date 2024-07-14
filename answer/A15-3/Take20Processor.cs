namespace TextFileProcessing;

// 書籍では触れていないが、TextFileProcessorには、改良の余地がある。
// ここまできた読者は、このTake20Processorを実装すると気が付くはずである。
// 21行目は処理不要にもかかわらず、読み込みが発生してしまう。
// そのため、この解答では、その部分も改善してている。
// Executeメソッドにbool型の戻り値を追加し、trueなら継続、falseなら処理終了の
// 判断をするようにしてある。
public class Take20Processor : ITextFileService {

    private int _count = 0;

    public void Initialize(string fname) { }

    // 20行目を出力したら、falseを返して処理を終了させている
    public bool Execute(string line) {
        Console.WriteLine(line);
        _count++;
        return _count < 20;
    }

    public void Terminate() { }

}