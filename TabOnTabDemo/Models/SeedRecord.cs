namespace TabOnTabDemo.Models;

public class SeedRecord
{
    public int Id { get; set; }
    public Person Person { get; set; } = new();
    public List<RecordItem> Items { get; set; } = new();
}

public class RecordItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Data { get; set; } = string.Empty;
}
