using AutoMapper;

namespace Daemon.DataStore;

public struct BaseReadableModelStore<D, V> 
    : IReadableModelStore<V>
    where D : IDbModel
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
        if (Storage.ModelDict.TryGetValue(id, out D? local)) {
            V viewModel = Mapper.Map<V>(local);
            return Task.FromResult<V?>(viewModel);
        }
        return Task.FromResult<V?>(default);
    }

    public Task<SortedDictionary<int, V>> GetAll(bool refresh, Func<V, bool> predicate)
    {
        IEnumerable<KeyValuePair<int, D>> filteredDict = Storage.ModelDict.Where(kvp => predicate(Mapper.Map<V>(kvp.Value)));
        IEnumerable<KeyValuePair<int, V>> mappedDict = filteredDict.Select(kvp => new KeyValuePair<int, V>(kvp.Key, Mapper.Map<V>(kvp.Value)));
        return new SortedDictionary<int, V>(mappedDict);
    }
}
