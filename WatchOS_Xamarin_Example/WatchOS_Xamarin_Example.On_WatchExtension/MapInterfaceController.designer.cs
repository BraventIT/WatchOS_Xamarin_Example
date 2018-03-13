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
    [Register ("MapInterfaceController")]
    partial class MapInterfaceController
    {
        [Outlet]
        WatchKit.WKInterfaceMap map { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (map != null) {
                map.Dispose ();
                map = null;
            }
        }
    }
}