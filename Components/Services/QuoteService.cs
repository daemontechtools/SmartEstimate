using SmartEstimate.Models;
using SmartEstimate.Mock;

namespace SmartEstimate.Services;

// Will be responsible for managine quotes
// Get, Create, Update, Delete
public class QuoteService
{
    private static Dictionary<int, Quote> _quoteDict = QuoteMock.GetQuoteMockDict();

    public IQueryable<Quote> GetQuotesAsQueryable()
    {
        return _quoteDict.Values.AsQueryable();
    }
}

