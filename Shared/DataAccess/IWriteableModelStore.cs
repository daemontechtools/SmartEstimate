using AutoMapper;


namespace Daemon.DataStore;

public interface IWriteableModelStore<V> where V : IDbModel {
    Task<V> Create(V viewModel);
    Task Delete(int id);
    Task Update(V viewModel);
    IMapper Mapper { get; }
}