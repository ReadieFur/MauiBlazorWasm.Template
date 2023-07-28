using MauiBlazorWasm.Template.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorWasm.Template.MAUI
{
    internal class PlatformInfoProvider : IPlatformInfo
    {
        public string GetPlatformName()
        {
            return DeviceInfo.Current.Platform.ToString();
        }
    }
}
