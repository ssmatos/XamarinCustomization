﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Customization.Services
{
	public interface IOrientation
	{
		DeviceOrientation GetOrientation();
	}
}
