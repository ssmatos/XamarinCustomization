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
using Customization2.Controls;
using Customization2.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryDroid))]
namespace Customization2.Droid.Renderers
{
	public class MyEntryDroid : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
				Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
		}

		public MyEntryDroid(Context context) : base(context)
		{
		}
	}
}