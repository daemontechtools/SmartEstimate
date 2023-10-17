namespace Daemon.DataStore;

public struct BaseModelStorage<D> : IModelStorage<D> where D : IDbModel
{
    public List<D> Models { get; set; }
    public event EventHandler? OnStateChanged;
    public void StateChanged() => OnStateChanged?.Invoke(this, EventArgs.Empty);

    public BaseModelStorage(List<D> mockModels)
    {
        Models = mockModels;
    }
}