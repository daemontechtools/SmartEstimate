namespace Daemon.DataStore;

public struct BaseModelStore<D> where D : IDbModel
{

    public BaseModelStore(IModelStorage<D> storage) {

    }

    public SortedDictionary<int, D>? ModelDict { get; private set; } = new();
    public event EventHandler? OnStateChanged;

    public void StateChanged()
    {
        OnStateChanged?.Invoke(this, EventArgs.Empty);
    }
}
