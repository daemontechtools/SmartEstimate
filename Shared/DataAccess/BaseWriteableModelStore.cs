using AutoMapper;


namespace Daemon.DataStore;

public struct BaseWriteableModelStore<D, V> 
    : IWriteableModelStore<V>
    where D : IDbModel
    where V : IDbModel
{
    public IModelStorage<D> Storage { get; }
    public IMapper Mapper { get; }

    public BaseWriteableModelStore(
        IModelStorage<D> storage,
        IMapper mapper
    ) {
        Storage = storage;
        Mapper = mapper;
    }

    public Task<V> Create(V viewModel)
    {
        D newModel = Mapper.Map<D>(viewModel);
        Storage.Models.Add(newModel);
        Storage.StateChanged();
        return Task.FromResult(viewModel);
    }

    public Task Delete(int id)
    {
        Storage.Models.Remove(Storage.Models.First(m => m.Id == id));
        Storage.StateChanged();
        return Task.CompletedTask;
    }

    public Task Update(V viewModel)
    {
        D newModel = Mapper.Map<D>(viewModel);
        int index = Storage.Models.FindIndex(m => m.Id == viewModel.Id);
        if (index >= 0) {
            Storage.Models[index] = newModel;
            Storage.StateChanged();
        }
        return Task.CompletedTask;
    }
}
