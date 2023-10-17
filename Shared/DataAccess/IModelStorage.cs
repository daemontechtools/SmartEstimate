namespace Daemon.DataStore;

public interface IModelStorage<D> where D : IDbModel {
    IList<D> Models { get; set;}
    event EventHandler? OnStateChanged;
    void StateChanged();
}