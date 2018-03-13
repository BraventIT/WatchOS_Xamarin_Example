// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace WatchOS_Xamarin_Example.On_WatchExtension
{
    [Register ("SwitchInterfaceController")]
    partial class SwitchInterfaceController
    {
        [Outlet]
        WatchKit.WKInterfaceSlider Slider { get; set; }


        [Outlet]
        WatchKit.WKInterfaceSwitch Switch { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Slider != null) {
                Slider.Dispose ();
                Slider = null;
            }

            if (Switch != null) {
                Switch.Dispose ();
                Switch = null;
            }
        }
    }
}