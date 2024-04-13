namespace MauiAppWithMudBlazor;

public interface IAppSettings
{
    string WebApiBaseUrl { get; set; }
    string WebApiDefaultVersion { get; set; }
    string AppName { get; set; }
}

public class AppSettings : IAppSettings
{
    public string WebApiBaseUrl { get; set; } = string.Empty;
    public string WebApiDefaultVersion { get; set; } = string.Empty;
    public string AppName { get; set; } = "SampleApp";
}