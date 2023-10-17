using AutoMapper;


namespace Daemon.DataStore;

public interface IReadableModelStore<V> where V : IDbModel {
    Task<V?> GetById(int id);
    Task<List<V>> GetAll(
        bool refresh = false, 
        Func<V, bool>? predicate = null
    );
    IMapper Mapper { get; }
}