using AutoMapper;


namespace Daemon.DataStore;

public struct BaseReadableModelStore<D, V> 
    : IReadableModelStore<V>
    where D : IDbModel
    where V : IDbModel
{
    public IModelStorage<D> Storage { get; }
    public IMapper Mapper { get; }

    public BaseReadableModelStore(
        IModelStorage<D> storage,
        IMapper mapper) {
        Mapper = mapper;
        Storage = storage;
    }

    public Task<V?> GetById(int id)
    {
        D? model = Storage.Models.First(m => m.Id == id);
        return Task.FromResult<V?>(Mapper.Map<V>(model));
    }

    public Task<IList<V>> GetAll(bool refresh, Func<V, bool> predicate)
    {
        IMapper mapper = Mapper;
        IList<V> result = Storage.Models
            .Where(m => predicate(mapper.Map<V>(m)))
            .Select(m => mapper.Map<V>(m))
            .ToList();
        return Task.FromResult(result);
    }
}
