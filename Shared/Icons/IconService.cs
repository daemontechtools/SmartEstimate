
using Microsoft.AspNetCore.Components;
namespace SmartEstimate.Icons;

public static class IconHelper
{
    public static RenderFragment TypeToRenderFragment(Type t, Dictionary<string, string>? attributes)
    {
        return builder =>
        {
            int index = 0;
            builder.OpenComponent(index++, t);
            if(attributes != null)
            {
                foreach(KeyValuePair<string, string> attribute in attributes)
                {
                    builder.AddAttribute(index++, attribute.Key, attribute.Value);
                }
            }
            builder.CloseComponent();
        };
    }
    public static RenderFragment TypeToRenderFragment(Type t)
    {
        Dictionary<string, string> attributes = new();
        return TypeToRenderFragment(t, attributes);
    }
}

