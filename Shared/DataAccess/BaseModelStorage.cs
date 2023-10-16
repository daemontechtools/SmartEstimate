namespace Daemon.DataStore;

public struct BaseModelStorage<D> : IModelStorage<D> where D : IDbModel
{
    public SortedDictionary<int, D> ModelDict { get; set; }
    public event EventHandler? OnStateChanged;
    public void StateChanged() => OnStateChanged?.Invoke(this, EventArgs.Empty);

    public BaseModelStorage(SortedDictionary<int, D> mockDict)
    {
        ModelDict = mockDict;
    }
}