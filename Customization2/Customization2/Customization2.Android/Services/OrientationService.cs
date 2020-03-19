using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Customization2.Droid.Services;
using Customization2.Services;
using Xamarin.Forms.Internals;

[assembly: Xamarin.Forms.Dependency(typeof(OrientationService))]
namespace Customization2.Droid.Services
{
	public class OrientationService : IOrientation
	{
		public DeviceOrientation GetOrientation()
		{
			IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

			SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
			bool isLandscape = orientation == SurfaceOrientation.Rotation90 ||
				orientation == SurfaceOrientation.Rotation270;
			return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
		}
	}
}