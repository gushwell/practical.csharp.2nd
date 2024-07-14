using System.Text.Json;
using System.Text.Json.Nodes;

var httpClient = new HttpClient();
var text = await GetFromWikipediaAsync(httpClient, "クリーンルーム設計");
Console.WriteLine(text);

static async Task<string> GetFromWikipediaAsync(HttpClient httpClient, string keyword) {
    // UriBuilderとFormUrlEncodedContentを使い、パラメーター付きのURLを組み立てる
    var builder = new UriBuilder("https://ja.wikipedia.org/w/api.php");
    var content = new FormUrlEncodedContent(new Dictionary<string, string>() {
        ["action"] = "query",
        ["format"] = "json",
        ["prop"] = "extracts",
        ["redirects"] = "1",
        ["explaintext"] = "1",
        ["titles"] = keyword,
    });
    // JsonStringを取得する
    builder.Query = await content.ReadAsStringAsync();
    var jsonString = await httpClient.GetStringAsync(builder.Uri);

    // JsonStringをパースして、コンテンツ文字列を取得する
    return GetContentString(jsonString);
}

// JsonStringをパースして、コンテンツ文字列を取得する
static string GetContentString(string jsonString) {
    var jsonNode = JsonNode.Parse(jsonString)!;
    var node = jsonNode["query"]!["pages"]!;
    var pagesElement = JsonSerializer.Deserialize<JsonElement>(node);
    var name = GetChildPropertyName(pagesElement);
    JsonElement contentElement = pagesElement.GetProperty(name);
    JsonElement extractElement = contentElement.GetProperty("extract");
    return extractElement.GetString() ?? "";
}

// element直下のキー名を取得する
static string GetChildPropertyName(JsonElement element) {
    return element.EnumerateObject().First().Name;
}
