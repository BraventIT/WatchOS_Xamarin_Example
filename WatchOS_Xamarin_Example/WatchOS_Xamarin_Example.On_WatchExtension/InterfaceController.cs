using System;

using WatchKit;
using Foundation;
using UIKit;

namespace WatchOS_Xamarin_Example.On_WatchExtension
{
    public partial class InterfaceController : WKInterfaceController
    {
        public int click;
        protected InterfaceController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        #region life circle

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine("{0} awake with context", this);

            //Btn_TouchMe.set
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
        #endregion
        #region Actions

        partial void Btn_TouchMe_TouchUpInside()
        {
            click++;
            lbl_Hello.SetText("Boton pulsado " + click.ToString() + " veces");
            lbl_Hello.SetHeight(60);
            Random rnd = new Random();
            lbl_Hello.SetTextColor(UIColor.FromRGB(rnd.Next(0,255),rnd.Next(0, 255),rnd.Next(0, 255)));
        }

        #endregion
    }
}
