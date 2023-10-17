using AutoMapper;


namespace Daemon.DataStore;

public interface IReadableModelStore<V> where V : IDbModel {
    Task<V?> GetById(int id);
    Task<IList<V>> GetAll(bool refresh, Func<V, bool> predicate);
    IMapper Mapper { get; }
}