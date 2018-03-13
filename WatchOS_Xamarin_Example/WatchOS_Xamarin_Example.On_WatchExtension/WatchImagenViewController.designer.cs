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
    [Register ("WatchImagenViewController")]
    partial class WatchImagenViewController
    {
        [Outlet]
        WatchKit.WKInterfaceImage imgBack { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgBack != null) {
                imgBack.Dispose ();
                imgBack = null;
            }
        }
    }
}