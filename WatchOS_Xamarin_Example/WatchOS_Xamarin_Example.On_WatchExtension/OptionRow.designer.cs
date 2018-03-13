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
    [Register ("OptionRow")]
    partial class OptionRow
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lbl_Row { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lbl_Row != null) {
                lbl_Row.Dispose ();
                lbl_Row = null;
            }
        }
    }
}