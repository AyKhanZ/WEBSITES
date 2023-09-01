using Newtonsoft.Json;

HttpClient client = new();

var title = "The Matrix";
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri($"https://imdb8.p.rapidapi.com/title/find?q={title}"),
    Headers =
                {
                      { "X-RapidAPI-Key", "5d1f93e7fcmsh31cd902310f3596p15d104jsn5981f11710d4" },
                      { "X-RapidAPI-Host", "imdb8.p.rapidapi.com" },
                },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var content = await response.Content.ReadAsStringAsync();

    //var json = content.ToString();
    //var result = JsonConvert.DeserializeObject<IMDb>(json);
    //return result;
    Console.WriteLine(content);
}

public class Principal
{
    public string LegacyNameText { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public List<string> Characters { get; set; }
}

public class Result
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string TitleType { get; set; }
    public int Year { get; set; }
    public List<Principal> Principals { get; set; }
}

public class IMDb
{
    public List<Result> Results { get; set; }
}