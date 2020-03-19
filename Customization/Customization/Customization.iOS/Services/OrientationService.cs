using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Customization.iOS.Services;
using Customization.Services;
using Foundation;
using UIKit;
using Xamarin.Forms.Internals;

[assembly: Xamarin.Forms.Dependency(typeof(OrientationService))]
namespace Customization.iOS.Services
{
	public class OrientationService : IOrientation
	{
		public DeviceOrientation GetOrientation()
		{
			UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

			bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
				orientation == UIInterfaceOrientation.PortraitUpsideDown;
			return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
		}
	}
}