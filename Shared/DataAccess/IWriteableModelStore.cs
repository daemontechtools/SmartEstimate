using AutoMapper;


namespace Daemon.DataStore;

public interface IWriteableModelStore<V> {
    Task<V?> Create(V viewModel);
    Task<bool> Delete(int id);
    Task<V?> Update(V viewModel);
    IMapper Mapper { get; }
}