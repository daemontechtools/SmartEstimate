namespace Daemon.DataStore;

public interface IModelStorage<D> where D : IDbModel {
    SortedDictionary<int, D> ModelDict { get; set;}
    event EventHandler? OnStateChanged;
    void StateChanged();
}