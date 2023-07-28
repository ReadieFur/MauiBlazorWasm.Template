using MauiBlazorWasm.Template.Shared;

namespace MauiBlazorWasm.Template.Web
{
    public class PlatformInfoProvider : IPlatformInfo
    {
        public string GetPlatformName()
        {
            return "Web";
        }
    }
}
