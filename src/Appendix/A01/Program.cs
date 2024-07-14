using System.Diagnostics;

// Windowsのみで実行可

try {
    await RunAndWaitNotepad();

} catch {
    Console.ReadLine();
}

static async Task RunAndWaitNotepad() {
    var path = @"%SystemRoot%\system32\notepad.exe";
    var fullpath = Environment.ExpandEnvironmentVariables(path);
    var timeout = TimeSpan.FromMinutes(10);
    var tokenSource = new CancellationTokenSource(timeout);
    using var process = Process.Start(fullpath);
    try {
        await process.WaitForExitAsync(tokenSource.Token);
    } catch (OperationCanceledException) {
        process.Kill();
        throw new TimeoutException();
    }
}

static async Task RunAndWaitNotepad2() {
    //    var path = @"%SystemRoot%\system32\notepad.exe";
    var path = @"man%SystemRoot%\system32\notepad.exe";
    var fullpath = Environment.ExpandEnvironmentVariables(path);
    var timeout = TimeSpan.FromMinutes(1);
    var startInfo = new ProcessStartInfo {
        FileName = "man",
        Arguments = "new",
        WindowStyle = ProcessWindowStyle.Maximized
    };

    var tokenSource = new CancellationTokenSource(timeout);
    using var process = Process.Start(startInfo);
    try {
        await process.WaitForExitAsync(tokenSource.Token);
    } catch (OperationCanceledException) {
        process.Kill();
        throw new TimeoutException();
    }
}

