using Microsoft.Extensions.Configuration;

// Code A-10
var environmentName = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
Console.WriteLine(environmentName);
var builder = new ConfigurationBuilder()
  .AddJsonFile(path: "appsettings.json")
  .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
  .AddEnvironmentVariables()
  .AddUserSecrets<Program>(optional: true);

IConfiguration configuration = builder.Build();

// Code A-11
var emailAddress = configuration["FromEmailAddress"];
var autoBackup = configuration["BackupOption:AutoBackup"];
var interval = configuration["BackupOption:Interval"];
Console.WriteLine($"emailAddress: {emailAddress}");
Console.WriteLine($"autoBackup={autoBackup}");
Console.WriteLine($"interval={interval}");


// Code A-12
var option = new BackupOption();
var section = configuration.GetSection("BackupOption");
section.Bind(option);
Console.WriteLine(option.ToString());


record BackupOption {
    public bool AutoBackup { get; set; }
    public string Folder { get; set; } = String.Empty;
    public int Interval { get; set; }
    public int StorageDuration { get; set; }
}