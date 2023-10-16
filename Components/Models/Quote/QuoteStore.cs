using AutoMapper;
using Daemon.DataStore;


namespace SmartEstimate.Models;

// Will be responsible for managine quotes
// Get, Create, Update, Delete
public class QuoteStore
{ 
    
    public IModelMockData<Quote> MockData { get; set; }
    public IModelStorage<Quote> Storage { get; set; }
    public IReadableModelStore<QuoteView> ReadableStore { get; set; }
    public IWritableModelStore<Quote, QuoteView> WritableStore { get; set; }


    public QuoteStore(IMapper Mapper)
    {
        MockData = new QuoteMock();
        Storage = new BaseModelStorage<Quote>(MockData.MockModelDict);
        ReadableStore = new BaseReadableModelStore<Quote, QuoteView>(Storage, Mapper);
        WritableStore = new BaseWriteableModelStore<Quote, QuoteView>(Storage, Mapper);
    }

    // Use Mock data to initialize the storage
    // Initialize ReadableModelStore with storage
    // Initialize WritableModelStore with storage

}

