using Foundation;
using System;

namespace WatchOS_Xamarin_Example.On_WatchExtension
{
    public partial class OptionRow : NSObject
    {
        public OptionRow (IntPtr handle) : base (handle)
        {
            
        }
        public void setTitle (string title)
        {
            lbl_Row.SetText(title);
        }
    }
}