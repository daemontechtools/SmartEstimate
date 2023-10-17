using AutoMapper;
using Daemon.DataStore;


namespace SmartEstimate.Models;

public class QuoteStore
{ 
    public IModelMockData<Quote> MockData { get; set; }
    public IModelStorage<Quote> Storage { get; set; }
    public IReadableModelStore<QuoteView> ReadableStore { get; set; }
    public IWriteableModelStore<QuoteView> WritableStore { get; set; }


    public QuoteStore(IMapper Mapper)
    {
        MockData = new QuoteMock();
        Storage = new BaseModelStorage<Quote>(MockData.MockModels);
        ReadableStore = new BaseReadableModelStore<Quote, QuoteView>(Storage, Mapper);
        WritableStore = new BaseWriteableModelStore<Quote, QuoteView>(Storage, Mapper);
    }
}

