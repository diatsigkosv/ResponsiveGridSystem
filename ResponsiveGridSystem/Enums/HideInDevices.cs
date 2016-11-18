using System;
using Windows.Foundation.Metadata;

namespace ResponsiveGridSystem.Enums
{
    [Flags]
    public enum HideInDevices
    {
        None = 0,
        MobileDown = 1,
        TabletDown = 2,
        DesktopDown = 4,
        HubDown = 8,
        MobileUp = 16,
        TabletUp = 32,
        DesktopUp = 64,
        HubUp = 128
    }
}