
public class Code18_17 {
    public Stream? CreateStream(string path) {
        if (!File.Exists(path))
            return null;
        return new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
    }
}