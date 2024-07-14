namespace TextFileProcessing;

// 書籍では触れていないが、TextFileProcessorには、改良の余地がある。
// ここまできた読者は、このTake20Processorを実装すると気が付くはずである。
// Executeメソッドにbool型の戻り値を追加し、trueなら継続、falseなら処理終了の
// 判断をするようにしてある。

public interface ITextFileService {
    void Initialize(string fname);
    bool Execute(string line);
    void Terminate();
}
