
public class Code18_15 {
    public class LaunchOption {
        public string[] Arguments { get; init; } = [];
        public string WorkingDirectory { get; init; } = ".";
        public ProcessWindowStyle WindowStyle { get; init; } = ProcessWindowStyle.Normal;
        public bool WaitForExit { get; init; } = false;
        public TimeSpan WaitTime { get; init; } = new TimeSpan(0);
        public int Priority { get; init; } = 0;
        public LaunchOption() {
        }
    }
    public static bool LaunchApp(string FilePath, LaunchOption option) {
        //    …
        // 単にビルドエラーを取るためのコード
        return true;
    }
}

