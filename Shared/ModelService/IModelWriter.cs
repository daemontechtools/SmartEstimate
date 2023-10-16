namespace SmartEstimate.ModelService;


public interface IModelWriter {
    public Task<T> Create<T>(T model);
    public Task<T> Update<T>(T model);
    public Task<T> Delete<T>(T model);
}