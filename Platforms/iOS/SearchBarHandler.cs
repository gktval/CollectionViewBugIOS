//this guarantees that this handler will only be used by the iOS application
#if IOS
using Microsoft.Maui.Platform;
using UIKit;
using System.Drawing;
namespace ScrollBarBug;

public class SearchBarHandler: Microsoft.Maui.Handlers.SearchBarHandler
{
    public static void AddDone()
    {
        Microsoft.Maui.Handlers.SearchBarHandler.Mapper.AppendToMapping("Done", (handler, view) =>
        {

            var toolbar = new UIToolbar(new RectangleF(0.0f, 0.0f, 50.0f, 44.0f));
            toolbar.BackgroundColor = UIColor.LightGray; // Set the color you prefer
            var doneButton = new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                handler.PlatformView.ResignFirstResponder();
            });

            toolbar.Items = new UIBarButtonItem[] {
                new UIBarButtonItem (UIBarButtonSystemItem.FlexibleSpace),
                doneButton
            };

            handler.PlatformView.InputAccessoryView = toolbar;

        });
    }
}
#endif
