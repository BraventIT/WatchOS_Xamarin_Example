using System;
using System.Collections.Generic;
using UIKit;
using WatchConnectivity;

namespace WatchOS_Xamarin_Example
{
    public partial class ViewController : UIViewController
    {

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            WCSessionManager.SharedManager.ApplicationContextUpdated += DidReceiveApplicationContext;

            label.Text = "NO DATA SEND";
            label.TextAlignment = UITextAlignment.Center;
            this.View.AddSubview(label);

            btnSend.TouchUpInside += (sender, e) =>
            {
                WCSessionManager.SharedManager.UpdateApplicationContext(new Dictionary<string, object>() { { "MessagePhone", $"HOLA!!" } });
            };
        }

        private void DidReceiveApplicationContext(WCSession session, Dictionary<string, object> applicationContext)
        {
            var message = (string)applicationContext["MessageWatch"];
            if (message != null)
            {
                Console.WriteLine($"Application context update received : {message}");
                InvokeOnMainThread(() =>
                {
                    label.Text = $"⌚️ : {message}";
                });
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
