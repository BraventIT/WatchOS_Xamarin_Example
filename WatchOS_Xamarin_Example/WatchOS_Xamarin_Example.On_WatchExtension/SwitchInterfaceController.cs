using System;

using WatchKit;
using Foundation;
using UIKit;

namespace WatchOS_Xamarin_Example.On_WatchExtension
{
    public partial class SwitchInterfaceController : WKInterfaceController
    {
        protected SwitchInterfaceController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine("{0} awake with context", this);
            Switch.SetColor(UIColor.Blue);
            Slider.SetColor(UIColor.Green);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine("{0} will activate", this);
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }
    }
}
