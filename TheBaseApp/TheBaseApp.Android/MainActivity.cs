﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TheBaseApp.Droid
{
	[Activity (Label = "TheBaseApp.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

		    var ft = FragmentManager.BeginTransaction();
		    ft.Replace(Resource.Id.base_framelayout, new NativeUiFragment(), "main");
		    ft.Commit();
		}
	}
}


