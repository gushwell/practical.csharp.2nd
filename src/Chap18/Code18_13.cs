
public class Code18_13 {
    public bool RenameFile(string path) {
        if (!File.Exists(path))
            return false;
        var lastWriteTime = File.GetLastWriteTime(path);
        var folder = Path.GetDirectoryName(path);
        var name = Path.GetFileNameWithoutExtension(path);
        var ext = Path.GetExtension(path);
        var newname = string.Format("{0}_{1:yyyyMMdd}{2}", name, lastWriteTime, ext);
        var newPath = Path.Combine(folder!, newname);
        File.Move(path, newPath);
        return true;
    }
}