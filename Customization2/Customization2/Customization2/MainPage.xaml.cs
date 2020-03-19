using Customization2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Customization2
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		void OnGetDeviceOrientationButtonClicked(object sender, EventArgs e)
		{
			DeviceOrientation orientation = DependencyService.Get<IOrientation>().GetOrientation();
			orientationLabel.Text = orientation.ToString();
		}
	}
}
