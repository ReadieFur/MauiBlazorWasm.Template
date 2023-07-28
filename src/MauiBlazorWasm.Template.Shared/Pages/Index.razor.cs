using Microsoft.AspNetCore.Components;

namespace MauiBlazorWasm.Template.Shared.Pages
{
    public partial class Index
    {
        [Inject]
        private IPlatformInfo? PlatformInfo { get; set; }
    }
}
