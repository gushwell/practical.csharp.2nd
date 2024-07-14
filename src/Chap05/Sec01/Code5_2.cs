class SampleClass {
    public string DefaultUrl { get; set; } = GetDefaultUrl();


    public static string GetDefaultUrl() {
        return "http://www.msn.com/ja-jp/news/";
    }

}