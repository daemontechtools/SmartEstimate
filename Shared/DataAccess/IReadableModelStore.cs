using AutoMapper;


namespace Daemon.DataStore;

public interface IReadableModelStore<V> {
    Task<V?> GetById(int id);
    Task<SortedDictionary<int, V>> GetAll(bool refresh, Func<V, bool> predicate);
    IMapper Mapper { get; }
}