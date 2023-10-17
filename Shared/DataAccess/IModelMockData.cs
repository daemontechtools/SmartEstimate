namespace Daemon.DataStore;

public interface IModelMockData<D> where D : IDbModel {
    public List<D> MockModels { get; set; }
}