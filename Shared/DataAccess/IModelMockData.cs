namespace Daemon.DataStore;

public interface IModelMockData<D> where D : IDbModel {
    public SortedDictionary<int, D> MockModelDict { get; set; }
}