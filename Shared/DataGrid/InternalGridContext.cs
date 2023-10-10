using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.AspNetCore.Components.QuickGrid.Infrastructure;

namespace SmartEstimate.DataGrid;


// The grid cascades this so that descendant columns can talk back to it. It's an internal type
// so that it doesn't show up by mistake in unrelated components.
internal sealed class InternalGridContext<T>
{
    public QuickGrid<T> Grid { get; }

    public InternalGridContext(QuickGrid<T> grid)
    {
        Grid = grid;
    }
}