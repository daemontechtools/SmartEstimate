using System.Collections.Immutable;
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
        IMapper mapper = Mapper;
        Dictionary<int, V> result = Storage.ModelDict
            .Where(kvp => predicate(mapper.Map<V>(kvp.Value)))
            .ToDictionary(kvp => kvp.Key, kvp => mapper.Map<V>(kvp.Value));
        SortedDictionary<int, V> sortedDictionary = new SortedDictionary<int, V>(result, Comparer<int>.Default);
        return Task.FromResult(sortedDictionary);
    }
}
