namespace ASP.NET_Project_with_API.Models
{
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




}

