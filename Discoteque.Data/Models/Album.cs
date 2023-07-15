namespace Discoteque.Data.models;

public class Album : BaseEntity<int>
{
 public String Name { get; set; } = "";
 public int Year { get; set; }
 public Genres Genre { get; set; } = Genres.Unknown;
}

public enum  Genres
{
    Rock,
    Metal,
    Salsa,
    Merengue,
    Folk,
    Indie,
    Techno,
    Vallenato,
    Unknown
}