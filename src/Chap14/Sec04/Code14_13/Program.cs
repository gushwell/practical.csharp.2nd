var httpClient = new HttpClient();
await GetHtmlExample(httpClient);

static async Task GetHtmlExample(HttpClient httpClient) {
    var url = "https://learn.microsoft.com/ja-jp/dotnet/core/introduction";
    var text = await httpClient.GetStringAsync(url);
    Console.WriteLine(text);
}

