//using Newtonsoft.Json;
//using System.Text;

////IMDbService service = new();



//StringBuilder? result;
//HttpClient client = new();
//HttpResponseMessage message = await client.GetAsync($"https://imdb8.p.rapidapi.com/title/find?q={movieTitle}");

//result = new(await message.Content.ReadAsStringAsync());
////result.Insert(0, """{ "Results": """);
////result.Append("}");

//var json = result.ToString();
//Console.WriteLine(json);
//var res = JsonConvert.DeserializeObject<IMDb>(json);
////if (result != null)
////{
////    var res = JsonConvert.DeserializeObject<IMDb>(json);
////    return res;
////}
////throw new NullReferenceException();

////IMDb imdb = await service.GetMovieInfoAsync(movieTitle);

//Console.WriteLine(res);

////if (imdb != null)
////{
////    // Обработка результатов
////    foreach (var result in imdb.Results)
////    {
////        Console.WriteLine("Title: " + result.Title);
////        Console.WriteLine("Year: " + result.Year);
////        Console.WriteLine("Type: " + result.TitleType);
////        Console.WriteLine("Principals:");
////        foreach (var principal in result.Principals)
////        {
////            Console.WriteLine("  Name: " + principal.Name);
////            Console.WriteLine("  Category: " + principal.Category);
////            Console.WriteLine("  Characters: " + string.Join(", ", principal.Characters));
////        }
////    }
////}
////else
////{
////    Console.WriteLine("No results found.");
////}
////public class IMDbService
////{
////    public async Task<IMDb> GetMovieInfoAsync(string title)
////    {
////        StringBuilder? result;
////        HttpClient client = new();
////        HttpResponseMessage message = await client.GetAsync($"https://imdb8.p.rapidapi.com/title/find?q={title}");

////        result = new(await message.Content.ReadAsStringAsync());
////        result.Insert(0, """{ "Results": """);
////        result.Append("}");

////        var json = result.ToString();
////        if (result != null)
////        {
////            var res = JsonConvert.DeserializeObject<IMDb>(json);
////            return res;
////        }
////        throw new NullReferenceException();

////    }

////}


//public class Principal
//{
//    public string LegacyNameText { get; set; }
//    public string Name { get; set; }
//    public string Category { get; set; }
//    public List<string> Characters { get; set; }
//}

//public class Result
//{
//    public string Id { get; set; }
//    public string Title { get; set; }
//    public string TitleType { get; set; }
//    public int Year { get; set; }
//    public List<Principal> Principals { get; set; }
//}

//public class IMDb
//{
//    public List<Result> Results { get; set; }
//}




using System.Net.Http.Headers;
var client = new HttpClient();
var request = new HttpRequestMessage
{
	Method = HttpMethod.Get,
	RequestUri = new Uri("https://imdb8.p.rapidapi.com/title/find?q=game%20of%20thr"),
	Headers =
	{
		{ "X-RapidAPI-Key", "5d1f93e7fcmsh31cd902310f3596p15d104jsn5981f11710d4" },
		{ "X-RapidAPI-Host", "imdb8.p.rapidapi.com" },
	},
};
using (var response = await client.SendAsync(request))
{
	response.EnsureSuccessStatusCode();
	var body = await response.Content.ReadAsStringAsync();
	Console.WriteLine(body);
}
