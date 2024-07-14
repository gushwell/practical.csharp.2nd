var tw = new TimeWatch();
tw.Start();
// スリープする
Thread.Sleep(1000);
TimeSpan duration = tw.Stop();
Console.WriteLine("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);


class TimeWatch {
    private DateTime _time;
    public void Start() {
        _time = DateTime.Now;
    }

    public TimeSpan Stop() {
        return DateTime.Now - _time;
    }
}