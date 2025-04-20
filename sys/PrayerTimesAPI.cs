using System.Text.Json;

public class PrayerTimesApi
{
    public static async Task<PrayerTimes> GetPrayerTimes(string location)
    {
        try
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync($"https://api.aladhan.com/v1/timingsByAddress?address={location}&method=2&school=1");
            PrayerTimes prayerTimes = JsonSerializer.Deserialize<PrayerTimes>(response);
            prayerTimes.GregorianDate = DateTime.Today;

            return prayerTimes;
        }
        catch (HttpRequestException)
        {
            return null;
        }
        catch (JsonException)
        {
            return null;
        }
    }
}

public class PrayerTimes
{
    public Data data { get; set; }
    public DateTime GregorianDate { get; set; }
}

public class Data
{
    public Timings timings { get; set; }
}

public class Timings
{
    public string Fajr { get; set; }
    public string Sunrise { get; set; }
    public string Dhuhr { get; set; }
    public string Asr { get; set; }
    public string Maghrib { get; set; }
    public string Isha { get; set; }
}