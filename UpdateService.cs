using System.Net.Http;
using System.Text.Json;

public static class UpdateService
{
    public static async Task CheckForUpdates()
    {
        var client = new HttpClient();

        string json =
            await client.GetStringAsync(
            "https://raw.githubusercontent.com/YOURNAME/ROA/main/version.json");

        var latest =
            JsonSerializer.Deserialize<VersionInfo>(json);

        Version current =
            new Version("1.0.0");

        Version online =
            new Version(latest.Version);

        if (online > current)
        {
            MessageBox.Show(
                $"Version {online} available");
        }
    }
}
