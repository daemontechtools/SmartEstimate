namespace Daemon.DataStore;

public struct BaseModelStorage<D> : IModelStorage<D> where D : IDbModel
{
    public IList<D> Models { get; set; }
    public event EventHandler? OnStateChanged;
    public void StateChanged() => OnStateChanged?.Invoke(this, EventArgs.Empty);

    public BaseModelStorage(IList<D> mockModels)
    {
        Models = mockModels;
    }
}