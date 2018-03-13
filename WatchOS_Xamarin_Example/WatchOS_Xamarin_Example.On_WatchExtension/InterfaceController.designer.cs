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
    [Register ("InterfaceController")]
    partial class InterfaceController
    {
        [Outlet]
        WatchKit.WKInterfaceButton Btn_TouchMe { get; set; }


        [Outlet]
        WatchKit.WKInterfaceLabel lbl_Hello { get; set; }


        [Action ("Btn_TouchMe_TouchUpInside")]
        partial void Btn_TouchMe_TouchUpInside ();

        void ReleaseDesignerOutlets ()
        {
            if (Btn_TouchMe != null) {
                Btn_TouchMe.Dispose ();
                Btn_TouchMe = null;
            }

            if (lbl_Hello != null) {
                lbl_Hello.Dispose ();
                lbl_Hello = null;
            }
        }
    }
}