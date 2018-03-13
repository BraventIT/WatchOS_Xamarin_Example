// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WatchOS_Xamarin_Example.On_WatchExtension
{
	[Register ("ToiPhoneController")]
	partial class ToiPhoneController
	{
		[Outlet]
		WatchKit.WKInterfaceLabel label { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel lblCount { get; set; }

		[Outlet]
		WatchKit.WKInterfaceSlider slider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceSlider sliderCount { get; set; }

		[Action ("buttonSendTouch")]
		partial void buttonSendTouch ();

		[Action ("SliderChange:")]
		partial void SliderChange (System.Single sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (lblCount != null) {
				lblCount.Dispose ();
				lblCount = null;
			}

			if (slider != null) {
				slider.Dispose ();
				slider = null;
			}

			if (sliderCount != null) {
				sliderCount.Dispose ();
				sliderCount = null;
			}

			if (label != null) {
				label.Dispose ();
				label = null;
			}
		}
	}
}
