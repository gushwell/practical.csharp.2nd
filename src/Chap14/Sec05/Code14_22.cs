using System.Diagnostics;

// Code 14.22
public class TaskExample {
    private readonly HttpClient _httpClient = new HttpClient();

    public async Task Run() {
        var tasks = new Task<string>[] {
            GetPageAsync(@"https://business.nikkei.com/rss/sns/nb.rdf"),
            GetPageAsync(@"https://www.nhk.or.jp/rss/news/cat3.xml"),
        };
        var results = await Task.WhenAll(tasks);

        // それぞれ先頭400文字を表示する
        var text = $"{results[0].Substring(0, 400)}\n\n{results[1].Substring(0, 400)}";
        Console.WriteLine(text);
    }


    private async Task<string> GetPageAsync(string urlstr) {
        var str = await _httpClient.GetStringAsync(urlstr);
        return str;
    }

}