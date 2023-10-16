namespace SmartEstimate.ModelService;


public interface IModelService<V, M>
    where V : IViewModel where M : class, IDatabaseModel
{
    IModelRepository<V, M> Repository { get; }
    IModelStore<V, M> Store { get; }
}