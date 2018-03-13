using System;

using WatchKit;
using Foundation;
using WatchConnectivity;
using System.Collections.Generic;

namespace WatchOS_Xamarin_Example.On_WatchExtension
{
    public partial class ToiPhoneController : WKInterfaceController
    {
        double SliderValue;
        protected ToiPhoneController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine("{0} awake with context", this);
            WCSessionManager.SharedManager.ApplicationContextUpdated += DidReceiveApplicationContext;
        }

        private void DidReceiveApplicationContext(WCSession session, Dictionary<string, object> applicationContext)
        {
            var message = (string)applicationContext["MessagePhone"];
            if (message != null)
            {
                Console.WriteLine($"Application context update received : {message}");
                label.SetText($"📱: {message}");
            }
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
        partial void buttonSendTouch()
        {
            WCSessionManager.SharedManager.UpdateApplicationContext(new Dictionary<string, object>() { { "MessageWatch", $"Valor del slider:{SliderValue}" } });
        }

        partial void SliderChange(System.Single sender)
        {
            SliderValue = sender;
        }

    }
}
