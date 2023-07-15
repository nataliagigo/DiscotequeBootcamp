namespace Discoteque.Data.models;

public class BaseEntity<TId> where TId: struct
{
    public TId id{get; set;}
}