using Microsoft.AspNetCore.Components;
using SmartEstimate.Models;
using SmartEstimate.Modal;

namespace SmartEstimate.Pages;

public partial class QuoteList : ComponentBase, IDisposable
{

    [Inject]
    private ModalService? _modalService { get; set; }

    [Inject]
    private QuoteStore? _quoteStore { get; set; }

    [Inject]

    ILoggerFactory? _loggerFactory { get; set; }


    private IQueryable<QuoteView> _quotes = new List<QuoteView>().AsQueryable();

    
    private bool IsLoading { get; set; } = true;
    private RenderFragment? _deleteConfirmation;
    private int? _itemIdToDelete;

    protected override async Task OnInitializedAsync()
    {
        List<QuoteView> _viewList = await _quoteStore!.ReadableStore.GetAll();
        _quotes = _viewList.AsQueryable();
        _quoteStore.Storage.OnStateChanged += OnStateChanged!;
        InitDeleteConfirmation();
        IsLoading = false;
    }

    private void InitDeleteConfirmation()
    {
        _deleteConfirmation = builder =>
        {
            builder.OpenComponent(0, typeof(DeleteConfirmation));
            builder.AddAttribute(1, "OnConfirm", EventCallback.Factory.Create<bool>(this, OnConfirm));
            builder.CloseComponent();
        };
    }

    private void ShowDeleteConfirmation(int id)
    {
        _itemIdToDelete = id;
        _modalService!.Show(_deleteConfirmation!);
    }

    private async Task OnConfirm(bool confirmed)
    {
       if (confirmed && _itemIdToDelete != null)
        {
            await _quoteStore!.WritableStore.Delete(_itemIdToDelete.Value);
            _itemIdToDelete = null;
        }
        _modalService!.Hide();
    }

    private async void OnStateChanged(object sender, EventArgs e)
    {
        await InvokeAsync(StateHasChanged);
    }

    public void Dispose()
    {
        _quoteStore!.Storage.OnStateChanged -= OnStateChanged!;
    }


    private async Task AddQuote()
    {
        var logger = _loggerFactory.CreateLogger<QuoteList>();
        logger.LogWarning("Someone has clicked me!");
        QuoteView newQuote = QuoteMock.GenerateRandomQuoteView();
        await _quoteStore!.WritableStore.Create(newQuote);
    }

    private async Task EditQuote()
    {
        Console.WriteLine("Edit Quote");
    }

    private async Task DeleteQuote()
    {
        Console.WriteLine("Delete Quote");
    }
}



