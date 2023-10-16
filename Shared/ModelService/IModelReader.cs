namespace SmartEstimate.ModelService;

public interface IModelReader {
    public Task<T> Get<T>(int id);
    public Task<List<T>> GetAll<T>();
}