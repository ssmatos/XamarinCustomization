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
using Customization2.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Customization2")]
[assembly: ExportEffect(typeof(DroidEntryColor), "ColorEffect")]

namespace Customization2.Droid.Effects
{
	public class DroidEntryColor : PlatformEffect
	{
        Android.Graphics.Color originalBackgroundColor = new Android.Graphics.Color(0, 0, 0, 0);
        Android.Graphics.Color backgroundColor;
        protected override void OnAttached()
        {
            try
            {
                backgroundColor = Android.Graphics.Color.Crimson;
                Control.SetBackgroundColor(backgroundColor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }

        }

        protected override void OnDetached()
        {

        }
        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == backgroundColor)
                    {
                        Control.SetBackgroundColor(originalBackgroundColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(backgroundColor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}