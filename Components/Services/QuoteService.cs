using SmartEstimate.Models;
using SmartEstimate.Mock;

namespace SmartEstimate.Services;

// Will be responsible for managine quotes
// Get, Create, Update, Delete
public class QuoteService
{
    private Dictionary<int, Quote> _quoteDict = MockQuote.GetMockQuoteDict();

    public List<Quote> GetQuotes()
    {
        return _quoteDict.Values.ToList();
    }
}

