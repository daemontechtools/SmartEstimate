namespace Daemon.DataStore;

public interface IModelMockData<D> where D : IDbModel {
    public IList<D> MockModels { get; set; }
}