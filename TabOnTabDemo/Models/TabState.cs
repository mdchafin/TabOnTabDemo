namespace TabOnTabDemo.Models;

public class TabState
{
    public string TabId { get; set; } = string.Empty;
    public RecordItem? SourceItem { get; set; }
    public string CurrentData { get; set; } = string.Empty;
    public bool IsModified { get; set; }
    public Dictionary<string, object> AdditionalState { get; set; } = new();
}
