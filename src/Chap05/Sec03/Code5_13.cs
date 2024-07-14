using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;

public class Code5_13 {

    public static void Run() {
        var appVer = new AppVersion(5, 1, 3, 125);
        Console.WriteLine(appVer);

    }

    public class AppVersion {
        public int Major { get; init; }
        public int Minor { get; init; }
        public int Build { get; init; }
        public int Revision { get; init; }

        public AppVersion(int major, int minor)
            : this(major, minor, 0, 0) {  //- 引数4つのコンストラクターを呼び出す
        }

        public AppVersion(int major, int minor, int build)
            : this(major, minor, build, 0) {  //- 引数4つのコンストラクターを呼び出す
        }

        public AppVersion(int major, int minor, int build, int revision) {
            Major = major;
            Minor = minor;
            Build = build;
            Revision = revision;
        }

        public override string ToString() =>
            $"{Major}.{Minor}.{Build}.{Revision}";

    }
}

