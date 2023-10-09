namespace SmartEstimate.Services;
using SmartEstimate.Models;

public class QuoteService
{
    //public List<Quote> Quotes { get; set; } = new();
    Dictionary<int, Quote> QuoteMap = new(); //myList.ToDictionary(o => o.Id);

    public List<Quote> GetQuotes()
    {
        return QuoteMap.Values.ToList();
    }
}

