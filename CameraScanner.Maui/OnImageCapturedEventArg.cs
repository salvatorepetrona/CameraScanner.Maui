using Microsoft.Maui.Graphics.Platform;
using Microsoft.Maui.ApplicationModel;

namespace CameraScanner.Maui
{
    public class OnImageCapturedEventArg : EventArgs
    {
        public PlatformImage Image { get; set; } = null;
    }
}