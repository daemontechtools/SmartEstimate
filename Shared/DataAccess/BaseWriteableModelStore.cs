namespace Daemon.DataStore;

public struct BaseWriteableModelStore<D, V> 
    : IWriteableModelStore<V>
    where D : IDbModel
{
    IModelStorage<D> Storage { get; }

    public BaseWriteableModelStore(IModelStorage<D> storage) {
        Storage = storage;
    }

    public async Task<V?> Create(V viewModel)
    {
        V? newViewModel = await Repository.Create(viewModel);
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
