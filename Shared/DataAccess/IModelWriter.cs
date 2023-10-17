namespace Daemon.DataStore;


public interface IWritableModelStore<D, V> : IModelStorage<D> 
    where D : IDbModel 
    where V : IDbModel 
{
    public Task<V> Create(V model);
    public Task<V> Update(V model);
    public Task<V> Delete(V model);
}