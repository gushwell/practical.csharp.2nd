namespace TextFileProcessing;

// ���Ђł͐G��Ă��Ȃ����ATextFileProcessor�ɂ́A���ǂ̗]�n������B
// �����܂ł����ǎ҂́A����Take20Processor����������ƋC���t���͂��ł���B
// Execute���\�b�h��bool�^�̖߂�l��ǉ����Atrue�Ȃ�p���Afalse�Ȃ珈���I����
// ���f������悤�ɂ��Ă���B

public interface ITextFileService {
    void Initialize(string fname);
    bool Execute(string line);
    void Terminate();
}
