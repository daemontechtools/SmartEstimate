using Microsoft.AspNetCore.Components;
namespace SmartEstimate.Modal;


// Show needs to be set AFTER animations are finished
// We need to know from the implementation of ModalContent (Delete Confirmation)
// how long the delay will be
public class ModalService
{
    private bool _show = false;

    private void SetShow(bool show, RenderFragment? fragment = null)
    {
        if (show != _show)
        {
            if(fragment != null) _contentFragment = fragment;
            _show = show;
            if(OnStateChange != null) OnStateChange.Invoke(this, show);
        }
    }
    public bool Visible { get => _show; }


    private RenderFragment? _contentFragment;
    public RenderFragment? Content
    {
        get => _contentFragment;
    }

    public EventHandler<bool>? OnStateChange;

    public void Show(RenderFragment content)
    {
        SetShow(true, content);
    }

    public void Hide()
    {
        SetShow(false);
    }
}

