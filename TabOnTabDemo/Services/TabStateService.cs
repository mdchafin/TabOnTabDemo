using TabOnTabDemo.Models;

namespace TabOnTabDemo.Services;

public class TabStateService
{
    private readonly Dictionary<string, TabState> _tabStates = new();

    public TabState GetOrCreateTabState(string tabId, RecordItem? sourceItem = null)
    {
        if (!_tabStates.ContainsKey(tabId))
        {
            _tabStates[tabId] = new TabState
            {
                TabId = tabId,
                SourceItem = sourceItem,
                CurrentData = sourceItem?.Data ?? string.Empty
            };
        }
        return _tabStates[tabId];
    }

    public void UpdateTabState(string tabId, Action<TabState> updateAction)
    {
        if (_tabStates.ContainsKey(tabId))
        {
            updateAction(_tabStates[tabId]);
        }
    }

    public void RemoveTabState(string tabId)
    {
        _tabStates.Remove(tabId);
    }

    public bool HasTabState(string tabId)
    {
        return _tabStates.ContainsKey(tabId);
    }
}
