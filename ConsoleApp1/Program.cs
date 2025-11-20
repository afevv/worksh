// See https://aka.ms/new-console-template for more information
        using System;
namespace ConsoleApp1
{
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
    }

    class Ebook : MediaItem
    {
        public string Author { get; init; }
        public int Pages { get; init; }
        public string ISBN { get; init; }

        public Ebook(string title, string author, string language, int pages, int year, string isbn)
            : base(title, language, year)
        {
            Author = author;
            Pages = pages;
            ISBN = isbn;
        }
    }

    class Movie : MediaItem
    {
        public string Director { get; init; }
        public int Duration { get; init; }

        public Movie(string title, string director, string language, int duration, int year)
            : base(title, language, year)
        {
            Director = director;
            Duration = duration;
        }
    }

    class Song : MediaItem
    {
        public string Artist { get; init; }
        public int Duration { get; init; }

        public Song(string title, string artist, string language, int duration, int year)
            : base(title, language, year)
        {
            Artist = artist;
            Duration = duration;
        }
    }

    class Videogame : MediaItem
    {
        public string Developer { get; init; }
        public string Platform { get; init; }

        public Videogame(string title, string developer, string language, string platform, int year)
            : base(title, language, year)
        {
            Developer = developer;
            Platform = platform;
        }
    }

    class App : MediaItem
    {
        public string Developer { get; init; }
        public string Platform { get; init; }

        public App(string title, string developer, string language, string platform, int year)
            : base(title, language, year)
        {
            Developer = developer;
            Platform = platform;
        }
    }

    class Podcast : MediaItem
    {
        public string Host { get; init; }
        public int Duration { get; init; }

        public Podcast(string title, string host, string language, int duration, int year)
            : base(title, language, year)
        {
            Host = host;
            Duration = duration;
        }
    }

    class Audiobook : MediaItem
    {
        public string Narrator { get; init; }
        public int Duration { get; init; }

        public Audiobook(string title, string narrator, string language, int duration, int year)
            : base(title, language, year)
        {
            Narrator = narrator;
            Duration = duration;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project compiles — ready to generate class diagram.");
        }
    }
}