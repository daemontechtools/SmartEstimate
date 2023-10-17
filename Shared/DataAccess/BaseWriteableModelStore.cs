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

    public Task<V?> Create(V viewModel)
    {
        Storage.Models.
        Storage.Models. Append<V>(viewModel); .Add(viewModel.Id, Mapper.Map<D>(viewModel));
        ModelDict.Add(newViewModel.Id, newViewModel);
        StateChanged();
        return newViewModel;
    }

    public async Task<bool> Delete(int id)
    {
        try
        {
            await Repository.Delete(id);
        }
        catch
        {
            return false;
        }
        ModelDict.Remove(id);
        StateChanged();
        return true;
    }


    public async Task<V?> Update(V viewModel)
    {
        V? newViewModel = await Repository.Update(viewModel);
        if (newViewModel != null)
        {
            ModelDict[newViewModel.Id] = newViewModel;
            StateChanged();
        }
        return newViewModel;
    }
}
