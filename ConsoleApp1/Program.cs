// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
enum Role { Admin = 1, Employee = 2, Borrower = 3 }

abstract class MediaItem
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Title { get; init; }
    public string Language { get; init; }
    public int? Year { get; init; } 
  

    protected MediaItem(string title, string language, int? year)
    {
        Title = title;
        Language = language;
        Year = year;
    }
    class Ebook : MediaItem
{
    public string Author { get; init; }
    public int Pages { get; init; }
    public string ISBN { get; init; }

    public Ebook(string title, string author, string language, int pages, int year, string isbn)
        : base(title, language, year)
    {
        Author = author; Pages = pages; ISBN = isbn;
    }
   class Movies : MediaItem
    {
        public string Director { get; init; }
        public int Duration { get; init; } 
        public Movies(string title, string director, string language, int duration, int year)
            : base(title, language, year)
        {
            Director = director; Duration = duration;
        }
    }
    class Songs : MediaItem
    {
        public string Artist { get; init; }
        public int Duration { get; init; }
        public Songs(string title, string artist, string language, int duration, int year)
            : base(title, language, year)
        {
            Artist = artist; Duration = duration;
        }
    }
    class Videogames : MediaItem
    {
        public string Developer { get; init; }
        public string Platform { get; init; }
        public Videogames(string title, string developer, string language, string platform, int year)
            : base(title, language, year)
        {
            Developer = developer; Platform = platform;
        }
    }
    class Apps : MediaItem
    {
        public string Developer { get; init; }
        public string Platform { get; init; }
        public Apps(string title, string developer, string language, string platform, int year)
            : base(title, language, year)
        {
            Developer = developer; Platform = platform;
        }
    }
    class Podcasts : MediaItem
    {
        public string Host { get; init; }
        public int Duration { get; init; }
        public Podcasts(string title, string host, string language, int duration, int year)
            : base(title, language, year)
        {
            Host = host; Duration = duration;
        }
    }
    class Audiobooks : MediaTypeHeaderValue
    {
        public string Narrator { get; init; }
        public int Duration { get; init; }
        public Audiobooks(string title, string narrator, string language, int duration, int year)
            : base(title, language, year)
        {
            Narrator = narrator; Duration = duration;
        }
    }