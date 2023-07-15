namespace Discoteque.Data.models;

public class Artist : BaseEntity<int>
{
    public string Name { get; set; } = "";
    public string Label { get; set; } = "";
    public bool IsOnTour { get; set; }
}