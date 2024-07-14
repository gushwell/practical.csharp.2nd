
public class Code18_16 {
    public void CreateStream(ref Stream? stream, string path) {
        if (stream is null) {
            if (!File.Exists(path))
                return;
            stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
        }
        return;
    }
}