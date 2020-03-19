﻿using Customization2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Customization2
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new CustomTabbedPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
